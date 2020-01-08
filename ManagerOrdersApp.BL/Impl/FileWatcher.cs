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
    class FileWatcher : IWatcher, ILoggable
    {
        private string _puthDirectory;
        private FileSystemWatcher _watcher;
        private ICollection<ILogger> _loggers;
        public event Action<string> LogEvent;
        public event Action<string> Created;
        public FileWatcher() : this(ConfigurationManager.AppSettings.Get("PathFolder"))
        {

        }

        public FileWatcher(string puthDirectory)
        {
            _puthDirectory = puthDirectory;
            _watcher = new FileSystemWatcher();
            _loggers = new HashSet<ILogger>();
        }



        public void Start()
        {
            if (_watcher==null)
            {
                _watcher = new FileSystemWatcher();
            }
            SubsribeOnEvents(_watcher);
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
            if (_watcher!=null)
            {
                UnsubscribeOnEvents(_watcher);
                _watcher.EnableRaisingEvents = false;
                _watcher.Dispose();
            }
           

        }
        private void SubsribeOnEvents(FileSystemWatcher watcher)
        {
            watcher.Created += (o, e) => LogEvent?.Invoke($"File: {e.Name} {e.ChangeType}");
            watcher.Changed += (o, e) => LogEvent?.Invoke($"File: {e.Name} {e.ChangeType}");
            watcher.Deleted += (o, e) => LogEvent?.Invoke($"File: {e.Name} {e.ChangeType}");
            watcher.Renamed += (o, e) => LogEvent?.Invoke($"File: {e.OldName} renamed to {e.Name}");
            watcher.Deleted += (o, e) => Created?.Invoke(e.FullPath);
        }
        private void UnsubscribeOnEvents(FileSystemWatcher watcher)
        {
            watcher.Created -= (o, e) => LogEvent?.Invoke($"File: {e.Name} {e.ChangeType}");
            watcher.Changed -= (o, e) => LogEvent?.Invoke($"File: {e.Name} {e.ChangeType}");
            watcher.Deleted -= (o, e) => LogEvent?.Invoke($"File: {e.Name} {e.ChangeType}");
            watcher.Renamed -= (o, e) => LogEvent?.Invoke($"File: {e.OldName} renamed to {e.Name}");
            watcher.Deleted -= (o, e) => Created?.Invoke(e.FullPath);
        }
    }
}
