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
    public class AirplaneTypeService : IAirplaneTypeService
    {
        public readonly IUnitOfWork data;

        public AirplaneTypeService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<AirplaneType> Get()
        {
            return data.Set<AirplaneType>().Get();
        }

        public AirplaneType GetById(int id)
        {
            return data.Set<AirplaneType>().GetById(id);
        }

        public void Create(AirplaneType entity)
        {
            data.Set<AirplaneType>().Create(entity);
        }

        public void Delete()
        {
            data.Set<AirplaneType>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<AirplaneType>().Delete(id);
        }

        public void Update(int id, AirplaneType entity)
        {
            data.Set<AirplaneType>().Update(id, entity);
        }
    }
}
