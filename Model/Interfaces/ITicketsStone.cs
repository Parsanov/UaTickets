using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;

namespace Model.Interfaces
{
    public interface ITicketsStone
    {
        List<Ticket> Tickets { get; set; }
    }
}
