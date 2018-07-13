using DAL.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public interface IAirplaneService
    {
        Airplane GetById(int id);

        IEnumerable<Airplane> Get();

        void Create(AirplaneDTO entity);

        void Update(int id, AirplaneDTO entity);

        void Delete();

        void Delete(int id);
    }
}
