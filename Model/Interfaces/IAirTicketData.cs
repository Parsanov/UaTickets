using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;

namespace Model.Interfaces
{
    public interface IAirTicketData
    {
        Task<List<AirTicket>> GetAll();
        void Add(List<AirTicket> ticket);
        bool Remove(AirTicket ticket);
        bool Save();
        bool AddUserId(UserTicket ticketUser);



    }
}
