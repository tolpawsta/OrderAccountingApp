﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.DAL.Entities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => new StringBuilder()
            .Append(FirstName)
            .Append(" ")
            .Append(LastName).ToString();

        public virtual ICollection<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        

    }
}
