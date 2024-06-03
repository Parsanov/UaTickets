using Application;
using Karambolo.Extensions.Logging.File;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Model.Interfaces;
using Npgsql;
using Persistence;
using Persistence.Data;
using UaTicketsAPI.Controllers.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<ITicketData, TicketData>();
builder.Services.AddSingleton<ITicketsStone, TicketsStone>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod());
});



var connectionString = builder.Configuration.GetConnectionString("MyPostgreSQLConnection");
builder.Services.AddDbContext<DataDBContext>(options =>
    options.UseNpgsql(connectionString, b => b.MigrationsAssembly("UaTicketsAPI")));

var app = builder.Build();

// Перевірка з'єднання з PostgreSQL при запуску
using (var scope = app.Services.CreateScope())
{
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
    var dbContext = scope.ServiceProvider.GetRequiredService<DataDBContext>();
    try
    {
        await dbContext.Database.OpenConnectionAsync();
        logger.LogInformation("З'єднання з PostgreSQL встановлено.");
    }
    catch (NpgsqlException ex)
    {
        logger.LogError(ex, "Помилка підключення до PostgreSQL: {ErrorMessage}", ex.Message);
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");
app.UseAuthorization();
app.MapControllers();
app.Run();
