using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ticket : Entity
    {
        public double Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
