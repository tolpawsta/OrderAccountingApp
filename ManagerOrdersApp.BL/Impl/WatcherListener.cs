using ManageOrdersApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BL.Impl
{
    public class WatcherListener
    {
        private IReaderService _readerService;

        public WatcherListener(IReaderService readerService)
        {
            _readerService = readerService;
        }
        public void OnCreated(string pathFile)
        {
            Task.Factory.StartNew(
                () => _readerService.Begin(pathFile)
                );

        }
    }
}
