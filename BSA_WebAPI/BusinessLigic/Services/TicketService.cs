using BusinessLigic.Interfaces;
using DAL;
using DAL.Models;
using Shared.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Services
{
    public class TicketService : ITicketService
    {
        public readonly IUnitOfWork data;

        public TicketService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<Ticket> Get()
        {
            return data.Set<Ticket>().Get();
        }

        public Ticket GetById(int id)
        {
            if (TicketValidation.ValidateId(id, data))
            {
                return data.Set<Ticket>().GetById(id);
            }
            else
            {
                throw new Exception();
            }        
        }

        public void Create(Ticket entity)
        {
            data.Set<Ticket>().Create(entity);
        }

        public void Delete()
        {
            data.Set<Ticket>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<Ticket>().Delete(id);
        }

        public void Update(int id, Ticket entity)
        {
            data.Set<Ticket>().Update(id, entity);
        }
    }
}
