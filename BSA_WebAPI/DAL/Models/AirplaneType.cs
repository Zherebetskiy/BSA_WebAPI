using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AirplaneType : Entity
    {
        public string Model { get; set; }
        public int Capacity { get; set; }
        public double CarryingCapacity { get; set; }
    }
}
