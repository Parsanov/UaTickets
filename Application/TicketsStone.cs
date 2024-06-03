using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;

namespace Application
{
    public class TicketsStone : ITicketsStone
    {
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
