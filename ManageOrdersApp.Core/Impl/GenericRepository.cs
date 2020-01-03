using ManageOrdersApp.Core.Interfaces;
using System;
using System.Linq;

namespace ManageOrdersApp.Core.Impl
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected IDbContext context;
        protected IGenericRepository<TEntity> dbSet;
        public void Create(TEntity entity)
        {
            dbSet.Create(entity);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Delete(entity);
        }

        public IQueryable<TEntity> Find(Func<TEntity, bool> predicate)
        {
           return dbSet.Find(predicate).AsQueryable();
        }

        public IQueryable<TEntity> GetAll()
        {
           return dbSet.GetAll();
        }

        public TEntity GetById(int id)
        {
            return GetById(id);
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
        }
    }
}
