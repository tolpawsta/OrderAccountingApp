using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.DAL.Entities;
using ManageOrdersApp.DAL.Repositories;
using ManageOrdersApp.Model;
using ManageOrdersApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.Impl
{
    public class UnitOfWork :IUnitOfWork, IDisposable
    {
        private ManagerContext _context;
       public Repository<>
        private bool _disposed = false;

        public UnitOfWork()
        {
            _context = new ManagerContext();
        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (customerRepository == null)
                    customerRepository = new CustomerRepository(_context);
                return customerRepository;
            }
        }
        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(_context);
                return productRepository;
            }
        }
        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(_context);
                return orderRepository;
            }
        }
        void Save()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
