using System;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface IWatcher:ILoggable
    {
        event Action<string> Created;
        void Stop();
        void Start();
    }
}
