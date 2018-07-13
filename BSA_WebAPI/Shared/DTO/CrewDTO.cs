using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public class CrewDTO
    {
        public int Id { get; set; }
        public int PilotId { get; set; }
        public int[] StewardessesId { get; set; }
    }
}
