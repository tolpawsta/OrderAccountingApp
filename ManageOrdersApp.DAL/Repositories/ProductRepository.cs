using ManageOrdersApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.Repositories
{
   public class ProductRepository
    {
        private readonly ManagerContext _context;
        private DbSet<Product> __product;
        private object _locker = new object();

        public ProductRepository(ManagerContext context)
        {
            _context = context;
            __product = _context.Product;
        }
        public void Create(Product product)
        {
            __product.Add(product);
        }
    }
}
