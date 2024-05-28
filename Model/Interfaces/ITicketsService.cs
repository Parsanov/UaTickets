using UaTickets.Model;

namespace Model.Interfaces
{
    public interface ITicketService
    {
        public List<Ticket> GetAllTicket();
        public Ticket GetTicket(int id);
        public bool DeleteTicket(int id);
        public void AddTicket(Ticket ticket);

    }
}
