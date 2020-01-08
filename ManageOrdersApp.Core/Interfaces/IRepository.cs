﻿using System;
using System.Linq;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);
        void Delete(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
    }
}