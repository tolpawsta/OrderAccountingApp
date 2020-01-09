using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.BLL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Product()
        {
            Orders = new HashSet<Order>();
        }

    }
}
