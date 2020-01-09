using ManageOrdersApp.Core.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.DAL.Entities
{
    public partial class Customer:Entity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        

    }
}
