﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface ILoggable
    {
        event Action<string> LogEvent;

    }
}
