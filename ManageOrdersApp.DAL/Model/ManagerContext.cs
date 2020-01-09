using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ManageOrdersApp.DAL.Entities;

namespace ManageOrdersApp.Model
{
    public partial class ManagerContext : DbContext
    {
        

        public ManagerContext():base("name=ManagerConnection")
        {
            Database.CreateIfNotExists();
        }
       public virtual DbSet<Customer> Castomers { get; set; }
      public virtual DbSet<Order> Orders { get; set; }
       public virtual DbSet<Product> Products { get; set; }
    }
}
