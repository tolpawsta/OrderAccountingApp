using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ManageOrdersApp.DAL.Entities;
using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.Core.Impl;

namespace ManageOrdersApp.Model
{
    public partial class ManagerContext : DbContext,IDbContext<Entity> 
    {
        

        public ManagerContext():base("name=ManagerConnection")
        {
            Database.CreateIfNotExists();
        }
       
       public virtual DbSet<Customer> Castomers { get; set; }
      public virtual DbSet<Order> Orders { get; set; }
       public virtual DbSet<Product> Products { get; set; }
        public DbSet<Entity> Entities { get ; set; }
    }
}
