using UaTickets.Model;
using UaTickets.ViewModel;

namespace Model.Interfaces
{
    public interface ITiketService
    {
        public  Task<List<Ticket>> GetAllTicket();
        public  Task<Ticket> GetTicket(int id);
        public  Task<Ticket> DeleteTicket(int id);
        public  Task<List<Ticket>> FindTickets(TicketVM ticket);
        public  Task<List<Ticket>> TicketsAccountFind(string idUser);

    }
}
