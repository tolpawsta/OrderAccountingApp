using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.BLL.Models
{
    public class ProductBL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<OrderBL> Orders { get; set; }
        public ProductBL()
        {
            Orders = new HashSet<OrderBL>();
        }

    }
}
