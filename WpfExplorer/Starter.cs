using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Properties;

namespace WpfExplorer
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<HelperModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
