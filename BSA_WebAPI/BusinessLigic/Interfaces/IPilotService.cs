using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public  interface IPilotService
    {
        Pilot GetById(int id);

        IEnumerable<Pilot> Get();

        void Create(Pilot entity);

        void Update(int id, Pilot entity);

        void Delete();

        void Delete(int id);
    }
}
