using System.Security.Cryptography;
using System.Xml.Serialization;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Forms.Local.ViewModels
{
   public class ExplorerViewModel : ObservableBase, IViewLoadable
   {
       private readonly IContainerProvider _containerProvider;
       private readonly IRegionManager _regionManager;

       public List<FolderInfo> Roots { get; init; }

        public ExplorerViewModel(IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }


        public void OnLoaded(IViewable view)
        {
            ImportContext("MainContent", "MainRegion");
            ImportContext("LocationContent", "LocationRegion");
        }

        private void ImportContext(string name, string regionName)
        {
            IViewable content = _containerProvider.Resolve<IViewable>(name);
            IRegion region = _regionManager.Regions[regionName];
            if (!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }
    }
}
