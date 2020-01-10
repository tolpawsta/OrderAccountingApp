using System;
using System.Collections.Generic;
using System.Text;

namespace ManageOrdersApp.BLL.Models
{
    public partial class OrderBL
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public int ReportId { get; set; }
        public ReportBL Report {get;set;}
        public int CustomerId { get; set; }
        public virtual CustomerBL Customer { get; set; }
        public int ProductId { get; set; }
        public virtual ProductBL Product { get; set; }
        public decimal Amount { get; set; }

        public OrderBL(int id, DateTime dateTime, CustomerBL customer, ProductBL product, decimal amount)
        {
            Id = id;
            DateTime = dateTime;
            Customer = customer;
            Product = product;
            Amount = amount;
        }

    }
}
