using Microsoft.EntityFrameworkCore;
using UaTickets.Model;

namespace UaTicketsAPI.Controllers.Data
{
    public class DataDBContext : DbContext
    {

        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }


        public DbSet<Ticket> tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Додайте конфігурації для ваших моделей тут, якщо потрібно.
        }

    }
}
