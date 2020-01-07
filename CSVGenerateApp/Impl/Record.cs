using CSVGenerateApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVGenerateApp.Impl
{
    class Record:IRecord
    {
        private static string Delimiter = ";";
        public DateTime OrderDate { get; }
        public string CustomerName { get; }
        public string ProdauctName { get; }
        public decimal Amount { get; }

        public Record(DateTime orderDate, string customerName, string prodauctName, decimal amount)
        {
            OrderDate = orderDate;
            CustomerName = customerName;
            ProdauctName = prodauctName;
            Amount = amount;
        }
        public Record(DateTime orderDate, string customerName, string prodauctName, decimal amount,string delimiter)
        {
            OrderDate = orderDate;
            CustomerName = customerName;
            ProdauctName = prodauctName;
            Amount = amount;
            Delimiter = delimiter;
        }
        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}{4}{1}{4}{2}{4}{3}",OrderDate,CustomerName,ProdauctName,Amount,Delimiter).ToString();
        }
    }
}
