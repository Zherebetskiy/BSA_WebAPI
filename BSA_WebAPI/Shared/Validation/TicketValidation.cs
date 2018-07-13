using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Validation
{
    public class TicketValidation
    {
        public static bool ValidateId(int id, IUnitOfWork data)
        {
            return data.Set<Ticket>().Get().Any(t => t.Id == id);
        }
    }
}
