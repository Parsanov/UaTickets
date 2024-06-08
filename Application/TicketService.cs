using Model.Interfaces;
using UaTickets.Model;
using UaTickets.ViewModel;

namespace Application
{
    public class TicketService : ITiketService
    {
        private readonly ITicketData _ticketData;

        public TicketService(ITicketData ticketData)
        {
            _ticketData = ticketData;
        }

        public Ticket DeleteTicket(int id)
        {
            var ticket = _ticketData.GetAll().FirstOrDefault(x => x.Id == id);

            return ticket;  
        }

        public List<Ticket> FindTickets(TicketVM ticket)
        {
            var ticketsData = _ticketData.GetAll();

            var findTickets = ticketsData.Where(tic => tic.DepartureCity == ticket.DepartureCity && 
                tic.ArrivalCity == ticket.ArrivalCity && tic.DepartureDate.Date == DateTime.Parse(ticket.DepartureDate).Date);

            return findTickets.ToList();
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
