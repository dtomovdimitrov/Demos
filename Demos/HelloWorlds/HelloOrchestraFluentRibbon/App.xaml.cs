using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HelloOrchestraFluentRibbon
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        Bootstrapper _bootstrapper = null;

        protected override void OnStartup(StartupEventArgs e)
        {
            _bootstrapper = new Bootstrapper();
            _bootstrapper.Run();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            

            _bootstrapper.Dispose();
            _bootstrapper = null;

            base.OnExit(e);
        }
    }
}
