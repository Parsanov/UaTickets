using Model.Interfaces;
using Model.Model;
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
        public List<AirTicket> AirTickets { get; set; } = new List<AirTicket>();
        public List<TrainTickets> TrainTickets { get; set; } = new List<TrainTickets>();
    }
}
