using System;
using System.Linq;

namespace ManageOrdersApp.Core.Interfaces
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
