using BusinessLigic.Interfaces;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Services
{
    public class PilotService : IPilotService
    {
        public readonly IUnitOfWork data;

        public PilotService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<Pilot> Get()
        {
            return data.Set<Pilot>().Get();
        }

        public Pilot GetById(int id)
        {
            return data.Set<Pilot>().GetById(id);
        }

        public void Create(Pilot entity)
        {
            data.Set<Pilot>().Create(entity);
        }

        public void Delete()
        {
            data.Set<Pilot>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<Pilot>().Delete(id);
        }

        public void Update(int id, Pilot entity)
        {
            data.Set<Pilot>().Update(id, entity);
        }
    }
}
