using ManageOrdersApp.BLL.Models;
using ManageOrdersApp.Core;
using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.Entities;
using ManageOrdersApp.Repositories;
using ManagerOrdersApp.BL.Impl;
using ManagerOrdersApp.BLL;
using ManagerOrdersApp.BLL.Impl;
using ManagerOrdersApp.BLL.Services;
using System;
using System.Configuration;

namespace OrderAccountingAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var manager = Configurator.CreateManager(new DependencyManager());
            string pathFile = ConfigurationManager.AppSettings.Get("PathWatcherFolder");
            IWatcher watcher = manager.CreateWatcher(pathFile);
            watcher.LogEvent += s => Console.WriteLine(s);
            watcher.Start();
            IReaderService readerService = new ReaderService();
            IWatcherListener listener = new WatcherListener(readerService);
            watcher.Created +=m=> listener.OnCreated(m);
            Console.ReadKey();
            
        }
    }
}
