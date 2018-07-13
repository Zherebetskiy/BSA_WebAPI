using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLigic
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity
    {
        public readonly IUnitOfWork data;

        public Service(IUnitOfWork data)
        {
            this.data = data;
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return data.Set<TEntity>().Get();
        }

        public virtual TEntity GetById(int id)
        {
            return data.Set<TEntity>().GetById(id);
        }

        public virtual void Create(TEntity entity)
        {
            data.Set<TEntity>().Create(entity);
        }

        public virtual void Delete()
        {
            data.Set<TEntity>().Delete();
        }

        public virtual void Delete(int id)
        {
            data.Set<TEntity>().Delete(id);
        }

        public virtual void Update(int id, TEntity entity)
        {
            data.Set<TEntity>().Update(id, entity);
        }
    }
}
