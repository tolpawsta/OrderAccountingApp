using ManageOrdersApp.Core;
using ManageOrdersApp.Core.Interfaces;
using ManagerOrdersApp.Bll.Impl.Loggers;
using ManagerOrdersApp.BLL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAccountingAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = Configurator.CreateManager(new DependencyManager());
            ILogger consoleLogger = manager.CreateLogger(new ConsoleLogger());
            IWatcher watcher = manager.CreateWatcher();
            watcher.AddLogger(consoleLogger);
            watcher.Start();

        }
    }
}
