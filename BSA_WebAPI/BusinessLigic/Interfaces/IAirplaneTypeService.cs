using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public interface IAirplaneTypeService
    {
        AirplaneType GetById(int id);

        IEnumerable<AirplaneType> Get();

        void Create(AirplaneType entity);

        void Update(int id, AirplaneType entity);

        void Delete();

        void Delete(int id);
    }
}
