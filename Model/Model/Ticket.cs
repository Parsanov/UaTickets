namespace UaTickets.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public string AirCompany { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public decimal CostTickets { get; set; }
        public string ClassSeat { get; set; }
        public string AirCompanyUrlLogo { get; set; }
    }
}
