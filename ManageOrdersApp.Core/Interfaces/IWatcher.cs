﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.Core.Interfaces
{
   public interface IWatcher
    {
       
        void Stop();
        void Start();
    }
}
