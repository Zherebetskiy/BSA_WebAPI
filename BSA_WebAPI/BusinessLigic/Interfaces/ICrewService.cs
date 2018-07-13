using DAL.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public interface ICrewService
    {
        Crew GetById(int id);

        IEnumerable<Crew> Get();

        void Create(CrewDTO entity);

        void Update(int id, CrewDTO entity);

        void Delete();

        void Delete(int id);
    }
}
