using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Pilot : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBorn { get; set; }
        public int Experience { get; set; }
    }
}
