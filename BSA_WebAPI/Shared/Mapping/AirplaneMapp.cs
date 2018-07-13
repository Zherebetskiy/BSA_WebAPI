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
    public class AirplaneMapp
    {
        public static Airplane Mapp(AirplaneDTO entity, IUnitOfWork data)
        {
            var airplanes = data.Set<AirplaneType>().Get();

            Mapper.Initialize(cfg => cfg.CreateMap<AirplaneDTO, Airplane>()
                       .ForMember("Type", opt => opt.MapFrom(c => airplanes.FirstOrDefault(a => a.Model == c.TypeModel))));

            var res = Mapper.Map<AirplaneDTO, Airplane>(entity);

            return res;
        }
    }
}
