using ManageOrdersApp.Core.Interfaces;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BL.Impl.Loggers
{
    public class FileLogger : ILogger, IDisposable
    {
        private string _pathToLogFile = String.Empty;
        private StreamWriter _writer;
        public FileLogger() : this(Assembly.GetExecutingAssembly().Location+ConfigurationManager.AppSettings.Get("DefaultPathToLogFile"))
        {
            
        }

        public FileLogger(string pathToLogFile)
        {
            _pathToLogFile = pathToLogFile;
        }

        public void Dispose()
        {
            _writer.Close();
        }

        public void Log(string message)
        {
            _writer?.WriteLine(message);
        }

        public void LogOnChanged(object sender, FileSystemEventArgs e)
        {
            _writer?.WriteLine($"File: {e.Name} {e.ChangeType}");
        }

        public void LogOnRenamed(object sender, RenamedEventArgs e)
        {
            _writer?.WriteLine($"File: {e.OldName} renamed to {e.Name}");
        }

        public void Start()
        {
            _writer = new StreamWriter(_pathToLogFile);
        }

        public void Stop()
        {
            _writer.Close();

        }
    }
}
