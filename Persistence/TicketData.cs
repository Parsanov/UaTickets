using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;

namespace Persistence
{
    public class TicketData : ITicketData
    {
        List<Ticket> tickets = new List<Ticket>
        {
            new Ticket
            {
                Id = 1,
                AirCompany = "Airline A",
                DepartureCity = "New York",
                ArrivalCity = "Los Angeles",
                DepartureDate = "2024-06-01T08:00:00",
                ArrivalDate = "2024-06-01T11:00:00",
                CostTickets = 300.00m,
                ClassSeat = "Economy"
            },
            new Ticket
            {
                Id = 2,
                AirCompany = "Airline B",
                DepartureCity = "San Francisco",
                ArrivalCity = "Chicago",
                DepartureDate = "2024-06-02T09:00:00",
                ArrivalDate = "2024-06-02T15:00:00",
                CostTickets = 200.00m,
                ClassSeat = "Business"
            },
            new Ticket
            {
                Id = 3,
                AirCompany = "Airline C",
                DepartureCity = "Miami",
                ArrivalCity = "Dallas",
                DepartureDate = "2024-06-03T07:00:00",
                ArrivalDate = "2024-06-03T09:30:00",
                CostTickets = 150.00m,
                ClassSeat = "First Class"
            },
            new Ticket
            {
                Id = 4,
                AirCompany = "Airline D",
                DepartureCity = "Seattle",
                ArrivalCity = "Denver",
                DepartureDate = "2024-06-04T10:00:00",
                ArrivalDate = "2024-06-04T13:00:00",
                CostTickets = 250.00m,
                ClassSeat = "Economy"
            },
            new Ticket
            {
                Id = 5,
                AirCompany = "Airline E",
                DepartureCity = "Boston",
                ArrivalCity = "Houston",
                DepartureDate = "2024-06-05T12:00:00",
                ArrivalDate = "2024-06-05T16:00:00",
                CostTickets = 350.00m,
                ClassSeat = "Business"
            }
        };



        public List<Ticket> GetAll()
        {
            return tickets;
        }

        public void Add(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void Remove(Ticket ticket)
        {
            tickets.Remove(ticket);
        }
    }
}
