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
    public class StewardessService : IStewardessService
    {
        public readonly IUnitOfWork data;

        public StewardessService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<Stewardess> Get()
        {
            return data.Set<Stewardess>().Get();
        }

        public Stewardess GetById(int id)
        {
            return data.Set<Stewardess>().GetById(id);
        }

        public void Create(Stewardess entity)
        {
            data.Set<Stewardess>().Create(entity);
        }

        public void Delete()
        {
            data.Set<Stewardess>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<Stewardess>().Delete(id);
        }

        public void Update(int id, Stewardess entity)
        {
            data.Set<Stewardess>().Update(id, entity);
        }
    }
}
