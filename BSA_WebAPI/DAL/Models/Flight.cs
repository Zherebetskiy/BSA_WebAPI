using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Flight : Entity
    {
        public string PointOfDeparture { get; set; }
        public DateTime TimeOfDeparture { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public List<Ticket> Ticket { get; set; }
    }

}
