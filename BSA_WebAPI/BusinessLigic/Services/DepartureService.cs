using BusinessLigic.Interfaces;
using DAL;
using DAL.Models;
using Shared.DTO;
using Shared.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Services
{
    public class DepartureService : IDepartureService
    {
        public readonly IUnitOfWork data;

        public DepartureService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<Departure> Get()
        {
            return data.Set<Departure>().Get();
        }

        public Departure GetById(int id)
        {
            return data.Set<Departure>().GetById(id);
        }

        public void Create(DepartureDTO entity)
        {
            var departureMapp =  DepartureMapp.Mapp(entity, data);
            data.Set<Departure>().Create(departureMapp);
        }

        public void Delete()
        {
            data.Set<Departure>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<Departure>().Delete(id);
        }

        public void Update(int id, DepartureDTO entity)
        {
            var departureMapp = DepartureMapp.Mapp(entity, data);
            data.Set<Departure>().Update(id, departureMapp);
        }
    }
}
