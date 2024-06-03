using Microsoft.AspNetCore.Mvc;
using Model.Interfaces;
using UaTickets.Model;
using UaTickets.ViewModel;

namespace UaTicketsAPI.Controllers
{
    [Route("[controller]")]
    public class AirTicketController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly ITicketsStone _stone;  

        public AirTicketController(ITicketService ticketService, ITicketsStone stone)
        {
            _ticketService = ticketService;
            _stone = stone;
        }

      
        [HttpPost]
        [Route("[action]")]
        public IActionResult FindTicket([FromBody] TicketVM ticketVM) 
        {
            var tickets = _ticketService.FindTickets(ticketVM);

            _stone.Tickets = tickets;

            return Ok();

        }


        [HttpGet]
        [Route("[action]")]
        public IActionResult GetTikects()
        {
            return Ok(_stone.Tickets);
        }




    }
}
