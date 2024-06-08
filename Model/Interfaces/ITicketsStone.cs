using Model.Model;
using UaTickets.Model;

namespace Model.Interfaces
{
    public interface ITicketsStone
    {
        List<AirTicket> AirTickets { get; set; }
        List<TrainTickets> TrainTickets { get; set; }
    }
}
