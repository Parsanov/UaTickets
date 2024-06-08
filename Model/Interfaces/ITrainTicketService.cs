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
    public interface ITrainTicketService
    {
        public Task<List<TrainTickets>> GetAllTicket();
        public Task<TrainTickets> GetTicket(int id);
        public Task<bool> DeleteTicket(string id);
        public Task<List<TrainTickets>> DepartureFindTickets(TicketVM ticket);
        public Task<List<TrainTickets>> ArrivalFindTickets(TicketVM ticket);
        public Task<List<TrainTickets>> TicketsAccountFind(string idUser);
        public bool BuyUserTicket(UserTicket buyUser);
    }
}
