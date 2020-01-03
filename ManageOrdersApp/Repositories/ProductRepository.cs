using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.DAL.Entities;
using ManageOrdersApp.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace ManageOrdersApp.Repositories
{
    public class ProductRepository : IGenericRepository<Product>
    {
        private ManagerContext _context;
        private DbSet<Product> _products;

        public ProductRepository(ManagerContext context)
        {
            _context = context;
            _products = _context?.Products;
        }

        public void Create(Product product)
        {
            _products.Add(product);
        }

        public void Delete(int id)
        {
            Product product = _products.Find(id);
            if (product!=null)
            {
                _products.Remove(product);
            }
            
        }

        public IQueryable<Product> Find(Func<Product, bool> predicate)
        {
            return _products.Where(predicate).AsQueryable();
        }

        public IQueryable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.Find(id);
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
        }
    }
}
