using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class AirplaneDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeModel { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int TimeSpan { get; set; }
    }
}
