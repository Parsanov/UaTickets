using Microsoft.EntityFrameworkCore;
using Model.Dtos;
using Model.Interfaces;
using UaTickets.Model;
using UaTicketsAPI.Controllers.Data;

namespace Persistence
{
    public class AirTicketData : IAirTicketData
    {
        private readonly DataDBContext _dBContext;

        public AirTicketData(DataDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<List<AirTicket>> GetAll()
        {
            return await _dBContext.AirTickets.ToListAsync(); 
        }

        public void Add(List<AirTicket> ticket)
        {
            _dBContext.AddRange(ticket);
            _dBContext.SaveChanges();
            
        }

        public bool Remove(AirTicket ticket)
        {
            var result = _dBContext.Remove(ticket);

            if (result != null)
            {
                _dBContext.SaveChanges();

                return true;
            }
            else
            {
                throw new Exception("Ticket not was delete");  
            }

        }

        public bool Save()
        {
            return _dBContext.SaveChanges() > 0;
        }

        public bool AddUserId(UserTicket ticketUser)
        {
            if (ticketUser is null)
            {
                return false;
            }

            var ticket = _dBContext.AirTickets.FirstOrDefault(t => t.Id.ToString() == ticketUser.TicketId);

            if (ticket is null)
            {
                return false;
            }
   
            ticket.UserId = ticketUser.UserId;

            var result = _dBContext.SaveChanges();

            if (result < 0)
            {
              return false;
            }

            return true;

        }
    }
}
