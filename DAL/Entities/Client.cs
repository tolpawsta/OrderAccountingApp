using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public List<Order> Orders { get; }
        public Client()
        {
            Orders = new List<Order>();
        }
        public Client(int id, int name) : this()
        {
            Id = id;
            Name = name;
        }

    }
}
