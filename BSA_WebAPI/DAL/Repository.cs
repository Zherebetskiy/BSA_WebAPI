using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return context.Set<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return context.Set<TEntity>().FirstOrDefault(c => c.Id == id);
        }

        public virtual void Create(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public virtual void Delete(int id)
        {
            var contextSet = context.Set<TEntity>();
            contextSet.Remove(contextSet.Find(c => c.Id == id));
        }

        public virtual void Delete()
        {
            var contextSet = context.Set<TEntity>();

            do
            {
                contextSet.Remove(contextSet[0]);
            } while (contextSet.Count!=0);
        }

        public virtual void Update(int id, TEntity entity)
        {
            Delete(id);
            entity.Id = id;
            Create(entity);
        }
    }
}
