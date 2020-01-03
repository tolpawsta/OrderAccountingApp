using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.Core.Interfaces
{
   public interface IFileWatcher
    {
        void OnChanged(object sender, FileSystemEventArgs e);
        void OnRenamed(object sender, RenamedEventArgs e);
        void Stop();
        void Start();
    }
}
