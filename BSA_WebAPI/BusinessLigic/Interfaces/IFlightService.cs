using DAL;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public interface IFlightService
    {
        Flight GetById(int id);

        IEnumerable<Flight> Get();

        void Create(FlightDTO entity);

        void Update(int id, FlightDTO entity);

        void Delete();

        void Delete(int id);
    }
}
