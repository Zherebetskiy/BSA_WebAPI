using AutoMapper;
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
    public  class AirplaneService : IAirplaneService
    {
        public readonly IUnitOfWork data;

        public AirplaneService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<Airplane> Get()
        {           
            return data.Set<Airplane>().Get();
        }

        public Airplane GetById(int id)
        {
            return data.Set<Airplane>().GetById(id);
        }

        public void Create(AirplaneDTO entity)
        {
            var mappAirplane = AirplaneMapp.Mapp(entity, data);

            data.Set<Airplane>().Create(mappAirplane);
        }

        public void Delete()
        {
            data.Set<Airplane>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<Airplane>().Delete(id);
        }

        public void Update(int id, AirplaneDTO entity)
        {
            var mappAirplane = AirplaneMapp.Mapp(entity, data);
             data.Set<Airplane>().Update(id, mappAirplane);
        }
    }
}
