using BusinessLigic.Interfaces;
using DAL;
using Shared.DTO;
using Shared.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Services
{
    public class FlightService : IFlightService
    {
        public readonly IUnitOfWork data;

        public FlightService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<Flight> Get()
        {
            return data.Set<Flight>().Get();
        }

        public Flight GetById(int id)
        {
            return data.Set<Flight>().GetById(id);
        }

        public void Create(FlightDTO entity)
        {
            var flightMapp = FlightMapp.Mapp(entity, data); 
            data.Set<Flight>().Create(flightMapp);
        }

        public void Delete()
        {
            data.Set<Flight>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<Flight>().Delete(id);
        }

        public void Update(int id, FlightDTO entity)
        {
            var flightMapp = FlightMapp.Mapp(entity, data);
            data.Set<Flight>().Update(id, flightMapp);
        }
    }
}
