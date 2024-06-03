using UaTickets.Model;
using UaTickets.ViewModel;

namespace Model.Interfaces
{
    public interface ITicketService
    {
        public List<Ticket> GetAllTicket();
        public Ticket GetTicket(int id);
        public Ticket DeleteTicket(int id);
        public List<Ticket> FindTickets(TicketVM ticket);
      
       

    }
}
