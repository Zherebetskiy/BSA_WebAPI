using DAL.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public  interface IDepartureService
    {
        Departure GetById(int id);

        IEnumerable<Departure> Get();

        void Create(DepartureDTO entity);

        void Update(int id, DepartureDTO entity);

        void Delete();

        void Delete(int id);
    }
}
