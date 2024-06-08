using Microsoft.EntityFrameworkCore;
using Model.Interfaces;
using UaTickets.Model;
using UaTicketsAPI.Controllers.Data;

namespace Persistence
{
    public class TicketData : ITicketData
    {
        private readonly DataDBContext _dBContext;

        public TicketData(DataDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<List<Ticket>> GetAll()
        {
            return await _dBContext.tickets.ToListAsync(); 
        }

        public void Add(List<Ticket> ticket)
        {
            _dBContext.AddRange(ticket);
            _dBContext.SaveChanges();
            
        }

        public void Remove(Ticket ticket)
        {
            _dBContext.Remove(ticket);
        }

        public bool Save()
        {
            return _dBContext.SaveChanges() > 0;
        }
    }
}
