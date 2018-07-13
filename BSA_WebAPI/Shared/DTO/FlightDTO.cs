using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class FlightDTO
    {
        public int Id { get; set; }
        public string PointOfDeparture { get; set; }
        public DateTime TimeOfDeparture { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int[] TicketId { get; set; }
    }
}
