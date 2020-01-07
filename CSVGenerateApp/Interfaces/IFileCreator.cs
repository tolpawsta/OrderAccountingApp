using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVGenerateApp.Interfaces
{
    interface IFileCreator
    {
        void Create(IFileable file);
    }
}
