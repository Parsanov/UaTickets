using Microsoft.AspNetCore.Mvc;
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

        public async Task<Ticket> DeleteTicket(int id)
        {
            var ticket = await _ticketData.GetAll();

            return ticket.FirstOrDefault(x => x.Id == id);  
        }

        public async Task<List<Ticket>> FindTickets(TicketVM ticket)
        {
            var ticketsData =  await _ticketData.GetAll();

            var findTickets = ticketsData.Where(tic => tic.DepartureCity == ticket.DepartureCity && 
                tic.ArrivalCity == ticket.ArrivalCity && tic.DepartureDate.Date == DateTime.Parse(ticket.DepartureDate).Date);

            return findTickets.ToList();
        }

        public async Task<List<Ticket>> GetAllTicket()
        {
           return  await _ticketData.GetAll();
        }

        public async Task<Ticket> GetTicket(int id)
        {
            var find = await _ticketData.GetAll();
            return  find.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<Ticket>> TicketsAccountFind(string idUser)
        {
            var allTickets =  await _ticketData.GetAll();

            var findTicketUser =  allTickets.Where(t => t.UserId == idUser).ToList();
            return findTicketUser;
        }
    }
}
