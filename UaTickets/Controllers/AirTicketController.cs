using Microsoft.AspNetCore.Mvc;
using Model.Interfaces;
using UaTickets.ViewModel;

namespace UaTicketsAPI.Controllers
{
    [Route("[controller]")]
    public class AirTicketController : Controller
    {
        private readonly ITiketService _ticketService;
        private readonly ITicketsStone _stone;  

        public AirTicketController(ITiketService ticketService, ITicketsStone stone)
        {
            _ticketService = ticketService;
            _stone = stone;
        }

      
        [HttpPost("FindTicket")]
        public async Task<IActionResult> FindTicket([FromBody] TicketVM ticketVM) 
        {
            var tickets = _ticketService.FindTickets(ticketVM);

            _stone.Tickets = await tickets;

            return Ok();

        }


        [HttpGet("GetTikects")]
        public IActionResult GetTikects()
        {
            return Ok(_stone.Tickets);
        }



        [HttpPost("AccountTickets")]
        public async Task<IActionResult> AccountTickets(string id)
        {
            var findTicket = await _ticketService.TicketsAccountFind(id);

            if (findTicket is null)
            {
                return BadRequest();
            }

            return Ok(findTicket);
        }






    }
}
