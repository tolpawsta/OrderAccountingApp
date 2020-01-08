using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.DAL.Entities;
using ManageOrdersApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.DAL.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private ManagerContext _context;

        public CustomerRepository(ManagerContext context)
        {
            _context = context;
        }

        public void Create(Customer customer)
        {
            _context.Castomers.Add(customer);
        }

        public void Delete(int id)
        {
            Customer customer = _context.Castomers.Find(id);
            if (customer!=null)
            {
                _context.Castomers.Remove(customer);
            }
        }

        public IQueryable<Customer> Find(Func<Customer, bool> predicate)
        {
            return _context.Castomers.Where(predicate).AsQueryable();
        }

        public IQueryable<Customer> GetAll()
        {
            return _context.Castomers;
        }

        public Customer GetById(int id)
        {
            return _context.Castomers.Find(id);
        }

        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
        }
    }
}
