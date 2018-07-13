using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly DataContext context;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public IRepository<TEntity> Set<TEntity>() where TEntity : Entity
        {
            return new Repository<TEntity>(context);
        }

        public int SaveChanges()
        {
            //for database
            throw new NotImplementedException();
        }
    }
}
