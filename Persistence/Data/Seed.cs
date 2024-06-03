using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;
using UaTicketsAPI.Controllers.Data;

namespace Persistence.Data
{
    public static class Seed
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<DataDBContext>>()))
            {
                // Перевірка чи база даних вже заповнена
                if (context.tickets.Any())
                {
                    return;   // База даних вже заповнена
                }

                // Додавання початкових даних
                context.tickets.AddRange(
                    new Ticket
                    {
                        AirCompany = "Airline A",
                        DepartureCity = "City A",
                        ArrivalCity = "City B",
                        DepartureDate = new DateTime(2024, 6, 1, 8, 30, 0),
                        ArrivalDate = new DateTime(2024, 6, 1, 10, 30, 0),
                        CostTickets = 200.50m,
                        ClassSeat = "Economy"
                    },
                    new Ticket
                    {
                        AirCompany = "Airline B",
                        DepartureCity = "City C",
                        ArrivalCity = "City D",
                        DepartureDate = new DateTime(2024, 6, 2, 14, 45, 0),
                        ArrivalDate = new DateTime(2024, 6, 2, 16, 45, 0),
                        CostTickets = 300.75m,
                        ClassSeat = "Business"
                    }
                // Додайте більше записів при необхідності
                );

                context.SaveChanges();
            }
        }
    } 

    
}
