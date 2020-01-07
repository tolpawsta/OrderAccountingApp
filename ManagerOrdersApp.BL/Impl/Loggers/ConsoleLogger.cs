using ManageOrdersApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.Bll.Impl.Loggers
{
    public class ConsoleLogger : ILogger
    {
        private bool isLogging;
        public ConsoleLogger()
        {
            isLogging = true;
        }
        public void Log(string message)
        {
            if (isLogging)
            {
                Console.WriteLine(message);
            }

        }

        public void LogOnChanged(object sender, FileSystemEventArgs e)
        {
            if (isLogging)
            {
                Console.WriteLine($"File: {e.Name} {e.ChangeType}");

            }
        }
        public void LogOnRenamed(object sender, RenamedEventArgs e)
        {
            if (isLogging)
            {
                Console.WriteLine($"File: {e.OldName} renamed to {e.Name}");
            }
        }

        public void Start()
        {
            isLogging = true;
        }

        public void Stop()
        {
            isLogging = false;
        }
    }
}
