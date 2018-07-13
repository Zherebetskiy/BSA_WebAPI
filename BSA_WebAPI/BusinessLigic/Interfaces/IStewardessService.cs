using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic.Interfaces
{
    public interface IStewardessService
    {
        Stewardess GetById(int id);

        IEnumerable<Stewardess> Get();

        void Create(Stewardess entity);

        void Update(int id, Stewardess entity);

        void Delete();

        void Delete(int id);
    }
}
