using ManageOrdersApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.Core
{
    public static class Configurator
    {
      public static IDependencyManager CreateManager(IDependencyManager manager) => manager;
    }
}
