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
    public class CrewService : ICrewService
    {
        public readonly IUnitOfWork data;

        public CrewService(IUnitOfWork data)
        {
            this.data = data;
        }

        public IEnumerable<Crew> Get()
        {
            return data.Set<Crew>().Get();
        }

        public Crew GetById(int id)
        {
            return data.Set<Crew>().GetById(id);
        }

        public void Create(CrewDTO entity)
        {
            var crewMapp = CrewMapp.Mapp(entity, data);
            data.Set<Crew>().Create(crewMapp);
        }

        public void Delete()
        {
            data.Set<Crew>().Delete();
        }

        public void Delete(int id)
        {
            data.Set<Crew>().Delete(id);
        }

        public void Update(int id, CrewDTO entity)
        {
            var crewMapp = CrewMapp.Mapp(entity, data);
            data.Set<Crew>().Update(id, crewMapp);
        }
    }
}
