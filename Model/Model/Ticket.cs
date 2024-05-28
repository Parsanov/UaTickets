namespace UaTickets.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public string AirCompany { get; set; }
        public string DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public decimal CostTickets { get; set; }
        public string ClassSeat { get; set; }
    }
}
