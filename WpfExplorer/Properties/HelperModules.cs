using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Properties
{
    internal class HelperModules : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<DirectoryManager>();
            containerRegistry.RegisterSingleton<FileService>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}
