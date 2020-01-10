using ManageOrdersApp.Core.Interfaces;

namespace ManagerOrdersApp.BLL.Impl
{
    public class DependencyManager : IDependencyManager
    {
        public ILogger CreateLogger(ILogger logger)
        {
            return logger;
        }

        public IWatcher CreateWatcher(string pathFile)
        {
            return new FileWatcher(pathFile);
        }
    }
}
