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
    public class OrderRepository : IRepository<Order>
    {
        private ManagerContext _context;

        public OrderRepository(ManagerContext context)
        {
            _context = context;
        }

        public void Create(Order order)
        {
            _context.Orders.Add(order);
        }

        public void Delete(int id)
        {
            Order order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
        }

        public IQueryable<Order> Find(Func<Order, bool> predicate)
        {
            return _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Product)
                .Where(predicate)
                .AsQueryable();
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders.Include(o=>o.Customer).Include(o=>o.Product);
        }

        public Order GetById(int id)
        {
            return _context.Orders.Find(id);
        }

        public void Update(Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
        }
    }
}
