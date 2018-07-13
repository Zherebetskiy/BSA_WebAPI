using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic
{
    public interface IService<TEntity> where TEntity : Entity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> Get();

        void Create(TEntity entity);

        void Update(int id, TEntity entity);

        void Delete();

        void Delete(int id);
    }
}
