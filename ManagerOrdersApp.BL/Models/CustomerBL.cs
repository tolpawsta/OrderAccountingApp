using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.BLL.Models
{
    public partial class CustomerBL
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<OrderBL> Orders { get; set; }
        public CustomerBL()
        {
            Orders = new HashSet<OrderBL>();
        }
        

    }
}
