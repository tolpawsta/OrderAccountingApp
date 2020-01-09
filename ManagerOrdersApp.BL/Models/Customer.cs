using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.BLL.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        

    }
}
