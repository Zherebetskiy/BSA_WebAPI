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
    public class CrewMapp
    {
        public static Crew Mapp(CrewDTO entity, IUnitOfWork data)
        {
            var pilots = data.Set<Pilot>().Get();
            var stewardesses = data.Set<Stewardess>().Get();

            var res = new Crew
            {
                Id = entity.Id,
                Pilot = pilots.FirstOrDefault(p => p.Id == entity.PilotId),
                Stewardesses = GetlistStewardess(entity.StewardessesId, stewardesses)
            };

            return res;
        }

        static List<Stewardess> GetlistStewardess(int[] ids, IEnumerable<Stewardess> AllStewardesses)
        {
            List<Stewardess> stewardesses = new List<Stewardess>();

            for (int i = 0; i < ids.Length; i++)
            {
                stewardesses.Add(AllStewardesses.FirstOrDefault(s => s.Id == ids[i]));
            }

            return stewardesses;
        }
    }
}
