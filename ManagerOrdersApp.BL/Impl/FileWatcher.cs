﻿using ManageOrdersApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BL.Impl
{
    class FileWatcher : IFileWatcher
    {
        private string _puthDirectory;

        public FileWatcher():base()
        {

        }

        public FileWatcher(string puthDirectory)
        {
            var puthDirectory=ConfigurationManager
            _puthDirectory = puthDirectory;
        }

        public void OnChanged(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnRenamed(object sender, RenamedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
