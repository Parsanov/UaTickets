using Model.Dtos;
using UaTickets.Model;
using UaTickets.ViewModel;

namespace Model.Interfaces
{
    public interface IAirTiketService
    {
        public  Task<List<AirTicket>> GetAllTicket();
        public  Task<AirTicket> GetTicket(int id);
        public  Task<bool> DeleteTicket(string id);
        public  Task<List<AirTicket>> DepartureFindTickets(TicketVM ticket);
        public Task<List<AirTicket>> ArrivalFindTickets(TicketVM ticket);
        public  Task<List<AirTicket>> TicketsAccountFind(string idUser);
        public bool BuyUserTicket(UserTicket buyUser);


    }
}
