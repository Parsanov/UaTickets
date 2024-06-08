using Model.Dtos;
using Model.Interfaces;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;
using UaTickets.ViewModel;

namespace Application
{
    public class TrainTicketService : ITrainTicketService
    {

        private readonly ITrainTicketData _ticketData;

        public TrainTicketService(ITrainTicketData ticketData)
        {
            _ticketData = ticketData;
        }

        public bool BuyUserTicket(UserTicket buyUser)
        {
            return _ticketData.AddUserId(buyUser);
        }

        public async Task<bool> DeleteTicket(string id)
        {
            var ticket = await _ticketData.GetAll();

            var findTicket = ticket.FirstOrDefault(x => x.Id.ToString() == id);

            var delete = _ticketData.Remove(findTicket);

            return delete ? true : false;
        }

        public async Task<List<TrainTickets>> DepartureFindTickets(TicketVM ticket)
        {
            var ticketsData = await _ticketData.GetAll();

            var findTickets = ticketsData.Where(tic => tic.DepartureCity == ticket.DepartureCity &&
                tic.ArrivalCity == ticket.ArrivalCity && tic.DepartureDate.Date == DateTime.Parse(ticket.DepartureDate).Date
                );

            var filteredTickets = findTickets.Where(tic => string.IsNullOrEmpty(tic.UserId));

            return filteredTickets.ToList();
        }

        public async Task<List<TrainTickets>> ArrivalFindTickets(TicketVM ticket)
        {
            var ticketsData = await _ticketData.GetAll();

            var findTickets = ticketsData.Where(tic => tic.DepartureCity == ticket.DepartureCity &&
                tic.ArrivalCity == ticket.ArrivalCity && tic.ArrivalDate.Value.Date == DateTime.Parse(ticket.DepartureDate).Date
                && tic.ClassSeat == ticket.ClassSeat);

            var filteredTickets = findTickets.Where(tic => string.IsNullOrEmpty(tic.UserId));

            return filteredTickets.ToList();
        }


        public async Task<List<TrainTickets>> GetAllTicket()
        {
            return await _ticketData.GetAll();
        }

        public async Task<TrainTickets> GetTicket(int id)
        {
            var find = await _ticketData.GetAll();
            return find.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<TrainTickets>> TicketsAccountFind(string idUser)
        {
            var allTickets = await _ticketData.GetAll();

            var findTicketUser = allTickets.Where(t => t.UserId == idUser).ToList();
            return findTicketUser;
        }
    }
}
