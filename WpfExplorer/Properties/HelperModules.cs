using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Properties
{
    internal class HelperModules : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<DirectoryManager>();
            containerRegistry.RegisterSingleton<FileService>();
            containerRegistry.RegisterSingleton<NavigatorService>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}
