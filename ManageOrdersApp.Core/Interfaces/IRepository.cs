using ManageOrdersApp.Core.Impl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity:Entity
    {
        IQueryable<TEntity> All { get; set; }
        TEntity GetById(int id);
        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);
        void Delete(int id);
        void Delete(IEnumerable<TEntity> entities);
        void Create(TEntity entity);
        void Create(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
    }
}
