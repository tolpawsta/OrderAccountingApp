using ManageOrdersApp.Core.Exeptions;
using ManageOrdersApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BLL.Impl
{
    class FileWatcher : IWatcher
    {
        private string _puthDirectory;
        private FileSystemWatcher _watcher;
        private ICollection<ILogger> _loggers;
        public FileWatcher() : this(ConfigurationManager.AppSettings.Get("PathFolder"))
        {

        }

        public FileWatcher(string puthDirectory)
        {
            _puthDirectory = puthDirectory;
            _watcher = new FileSystemWatcher();
            _loggers = new HashSet<ILogger>();
        }

        public void AddLogger(ILogger logger)
        {
            if (_loggers.Contains(logger))
            {
                throw new LoggerException("Such logger exists");
            }
            _watcher.Created += logger.LogOnChanged;
            _watcher.Changed += logger.LogOnChanged;
            _watcher.Deleted += logger.LogOnChanged;
            _watcher.Renamed += logger.LogOnRenamed;
            _loggers.Add(logger);
        }

        public void Start()
        {
            _watcher.Path = _puthDirectory;
            _watcher.Filter = "*.csv";
            _watcher.NotifyFilter = NotifyFilters.LastWrite |
           NotifyFilters.LastAccess |
           NotifyFilters.FileName |
           NotifyFilters.DirectoryName;
            _watcher.IncludeSubdirectories = true;
            _watcher.EnableRaisingEvents = true;

        }

        public void Stop()
        {
            _watcher.EnableRaisingEvents = false;
        }
    }
}
