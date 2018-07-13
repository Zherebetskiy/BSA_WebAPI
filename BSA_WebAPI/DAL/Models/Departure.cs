using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Departure : Entity
    {
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public Crew Crew { get; set; }
        public Airplane Airplane { get; set; }
    }
}
