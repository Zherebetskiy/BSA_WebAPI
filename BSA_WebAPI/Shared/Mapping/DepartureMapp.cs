using AutoMapper;
using DAL;
using DAL.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Mapping
{
    public class DepartureMapp
    {
        public static Departure Mapp(DepartureDTO entity, IUnitOfWork data)
        {
            var crews = data.Set<Crew>().Get();
            var airplanes = data.Set<Airplane>().Get();

            Mapper.Initialize(cfg => cfg.CreateMap<DepartureDTO, Departure>()
                       .ForMember("Crew", opt => opt.MapFrom(c => crews.FirstOrDefault(a => a.Id == c.CrewId)))
                       .ForMember("Airplane", opt => opt.MapFrom(c => airplanes.FirstOrDefault(a => a.Id == c.AirplaneId))));

            var res = Mapper.Map<DepartureDTO, Departure>(entity);

            return res;
        }
    }
}
