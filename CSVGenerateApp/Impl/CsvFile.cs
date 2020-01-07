using CSVGenerateApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVGenerateApp.Impl
{
    public class CsvFile:IFileable
    {
        public string Name { get; }
        public ICollection<IRecord> Records { get; }

        public CsvFile():this("Default")
        {
            
        }
        public CsvFile(string name)
        {
            Name = name;
            Records = new HashSet<IRecord>();
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var record in Records)
            {
                sb.AppendLine(record.ToString());
            }
            return sb.ToString();
        }
    }
}
