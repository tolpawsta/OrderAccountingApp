using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVGenerateApp.Interfaces
{
    public interface IRecord
    {
        DateTime OrderDate { get; }
        string CustomerName { get; }
        string ProdauctName { get; }
        decimal Amount { get; }
    }
}
