using Microsoft.AspNetCore.Mvc;
using Model.Interfaces;

namespace UaTicketsAPI.Controllers
{
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_ticketService.GetAllTicket());
        }
    }
}
