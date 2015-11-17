using Catel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using System.Windows;
using HelloOrchestraFluentRibbon.ViewModels;

namespace HelloOrchestraFluentRibbon
{
    public class Bootstrapper : BootstrapperBase<MainWindow>, IDisposable
    {
        protected override DependencyObject CreateShell()
        {
            var serviceLocator = this.GetServiceLocator();
            var viewModel = serviceLocator.ResolveType<MainWindowViewModel>();
            var view = serviceLocator.ResolveType<MainWindow>();

            view.DataContext = viewModel;

            return view;

            
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    //if (Container != null)
                    //    Container.Dispose();

                    ServiceLocator.Default.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Bootstrapper() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
