using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public interface ITicketService
    {
        Ticket GetById(int id);

        IEnumerable<Ticket> Get();

        void Create(Ticket entity);

        void Update(int id, Ticket entity);

        void Delete();

        void Delete(int id);
    }
}
