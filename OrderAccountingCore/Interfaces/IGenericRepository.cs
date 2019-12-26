using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderAccountingCore.Interfaces
{
   public interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);
        void Delete(TEntity entity);
        void Create(TEntity entity);
        void Update(TEntity entity);
    }
}
