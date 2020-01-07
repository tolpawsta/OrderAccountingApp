using ManageOrdersApp.Core.Interfaces;
using ManagerOrdersApp.Bll.Impl.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BLL.Impl
{
    public class DependencyManager : IDependencyManager
    {
        public ILogger CreateLogger(ILogger logger)
        {
            return logger;
        }

        public IWatcher CreateWatcher()
        {
            return new FileWatcher();
        }
    }
}
