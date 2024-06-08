using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class TrainTickets
    {
        public int Id { get; set; }
        public string TrainCompany { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public decimal CostTickets { get; set; }
        public string ClassSeat { get; set; }
        public string TrainCompanyUrlLogo { get; set; }
        public string? UserId { get; set; }
    }
}
