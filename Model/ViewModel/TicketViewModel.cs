namespace UaTickets.ViewModel
{
    public class TicketViewModel
    {
        public string AirCompany { get; set; }
        public string DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public string DepertureDate { get; set; }
        public string ArrivalDate { get; set; }
        public decimal CostTickets { get; set; }
        public string ClassSeat { get; set; }
    }
}
