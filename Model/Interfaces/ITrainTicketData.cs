using Model.Dtos;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;
using UaTickets.ViewModel;

namespace Model.Interfaces
{
    public interface ITrainTicketData
    {
        Task<List<TrainTickets>> GetAll();
        void Add(List<TrainTickets> ticket);
        bool Remove(TrainTickets ticket);
        bool Save();
        bool AddUserId(UserTicket ticketUser);
    }
}
