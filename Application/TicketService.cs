using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using UaTickets.Model;

namespace Application
{
    public class TicketService : ITicketService
    {
        private readonly ITicketData _ticketData;

        public TicketService(ITicketData ticketData)
        {
            _ticketData = ticketData;
        }

        public void AddTicket(Ticket ticket)
        {
            _ticketData.Add(ticket);
        }

        public bool DeleteTicket(int id)
        {
            var ticket = _ticketData.GetAll().FirstOrDefault(x => x.Id == id);

            return ticket != null;  
        }

        public List<Ticket> GetAllTicket()
        {
           return _ticketData.GetAll();
        }

        public Ticket GetTicket(int id)
        {
            return _ticketData.GetAll().FirstOrDefault(x => x.Id == id);
        }
    }
}
