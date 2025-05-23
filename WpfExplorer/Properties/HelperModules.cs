﻿using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Properties
{
    internal class HelperModules : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ColorManager>();
            containerRegistry.RegisterSingleton<DirectoryManager>();
            containerRegistry.RegisterSingleton<FileService>();
            containerRegistry.RegisterSingleton<NavigatorService>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}
