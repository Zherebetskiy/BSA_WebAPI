using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public interface IRepository<TEntity> where TEntity : Entity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> Get();

        void Create(TEntity entity);

        void Update(int id, TEntity entity);

        void Delete();

        void Delete(int id);
    }
}
