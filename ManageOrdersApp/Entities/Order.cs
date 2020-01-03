﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.DAL.Entities
{
    public partial class Order
    {
        public long Id { get; set; }
        public DateTime OrderDateTime { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public decimal Amount { get; set; }

        public Order(int id, DateTime orderDateTime, Customer customer, Product product, decimal amount)
        {
            Id = id;
            OrderDateTime = orderDateTime;
            Customer = customer;
            Product = product;
            Amount = amount;
        }

    }
}
