using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Airplane : Entity
    {
        public string Name { get; set; }
        public AirplaneType Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TimeSpan { get; set; }
    }
}
