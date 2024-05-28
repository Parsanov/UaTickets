using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaTickets.Model;

namespace Model.Interfaces
{
    public interface ITicketData
    {
        List<Ticket> GetAll();
        void Add(Ticket ticket);
        void Remove(Ticket ticket);
    }
}
