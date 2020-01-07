using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVGenerateApp.Interfaces
{
    interface IFileable
    {
        string Name { get; }
        ICollection<IRecord> Records { get; }
    }
}
