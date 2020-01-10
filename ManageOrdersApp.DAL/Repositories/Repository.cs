using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.DAL.Model;
using ManageOrdersApp.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ManageOrdersApp.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly TestContext _context;
        private DbSet<TEntity> _entities;
        private object _locker = new object();

        public Repository(TestContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> All => Entities;

        public void Create(TEntity entity)
        {
            lock (_locker)
            {
                if (entity == null)
                {
                    throw new ArgumentException(nameof(entity));
                }
                try
                {
                    Entities.Add(entity);
                    _context.SaveChanges();
                }
                catch (Exception exception)
                {

                    throw new Exception(exception.Message);
                }

            }
            
        }

        public void Create(IEnumerable<TEntity> entities)
        {
            lock (_locker)
            {
                Entities.AddRange(entities);
            }
        }

        public void Delete(int id)
        {
            TEntity entity = Entities.Find(id);
            

            lock (_locker)
            {
                try
                {
                    if (entity==null)
                    {
                        throw new Exception($"Entity not found!");
                    }
                    Entities.Remove(entity);
                }
                catch (Exception exception)
                {

                    throw exception;
                }
            }
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            lock (_locker)
            {
                try
                {
                    Entities.RemoveRange(entities);
                }
                catch (Exception exeption)
                {

                    throw exeption;
                }
            }
        }

        public IQueryable<TEntity> Find(Func<TEntity, bool> predicate)
        {
           return Entities.Where(predicate).AsQueryable();
        }

        public TEntity GetById(int id)
        {
            return Entities.Find(id);
        }

        public void Update(TEntity entity)
        {
            lock (_locker)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            lock (_locker)
            {
                _context.Entry(entities).State = EntityState.Modified;
            }
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        private DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<TEntity>();
                }
                return _entities;
            }
        }
    }
}
