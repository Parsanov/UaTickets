﻿using Microsoft.AspNetCore.Mvc;
using Model.Dtos;
using Model.Interfaces;
using Newtonsoft.Json.Linq;
using UaTickets.ViewModel;

namespace UaTicketsAPI.Controllers
{
    [Route("[controller]")]
    public class AirTicketController : Controller
    {
        private readonly IAirTiketService _ticketService;
        private readonly ITicketsStone _stone;

        public AirTicketController(IAirTiketService ticketService, ITicketsStone stone)
        {
            _ticketService = ticketService;
            _stone = stone;
        }

      
        [HttpPost("FindTicket")]
        public async Task<IActionResult> FindTicket([FromBody] TicketVM ticketVM) 
        {
            var tickets = _ticketService.DepartureFindTickets(ticketVM);

            _stone.AirTickets = await tickets;


            return Ok();

        }


        [HttpGet("GetTikects")]
        public IActionResult GetTikects()
        {
            return Ok(_stone.AirTickets);
        }



        [HttpPost("BuyTicket")]
        public async Task<IActionResult> BuyTicket([FromBody] UserTicket buyUser)
        {
            var result = _ticketService.BuyUserTicket(buyUser);

            if (result is true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost("AccountTickets")]
        public async Task<IActionResult> AccountTickets([FromBody] FindUserId userId)
        {
           
            var findTicket = await _ticketService.TicketsAccountFind(userId.userId);

            if (findTicket is null)
            {
                return NotFound();
            }

            return Ok(findTicket);
        }


        [HttpPost("DeleteTicket")]
        public async Task<IActionResult> DeleteTicket([FromBody] UserTicket ticket)
        {

            var result = await _ticketService.DeleteTicket(ticket.TicketId);

            if (result is true)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
