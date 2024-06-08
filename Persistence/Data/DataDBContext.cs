using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using UaTickets.Model;
using Model.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace UaTicketsAPI.Controllers.Data
{
    public class DataDBContext : IdentityDbContext<AppUser>
    {
        public DbSet<AirTicket> AirTickets { get; set; }
        public DbSet<TrainTickets> TrainTickets { get; set; }

        public DataDBContext(DbContextOptions<DataDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure your identity roles
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
