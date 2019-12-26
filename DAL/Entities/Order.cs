using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Order
    {
        public int Id { get; }
        public DateTime OrderDateTime { get; }
        public Client Client { get; }
        public Product Product { get; }
        public decimal Amount { get; }

        public Order(int id, DateTime orderDateTime, Client client, Product product, decimal amount)
        {
            Id = id;
            OrderDateTime = orderDateTime;
            Client = client;
            Product = product;
            Amount = amount;
        }

    }
}
