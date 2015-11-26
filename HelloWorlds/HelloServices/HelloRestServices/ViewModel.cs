using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace HelloRestServices
{
    public class ViewModel : BindableBase
    {
        private PanoramioData data;

        public PanoramioData Data
        {
            get { return data; }
            set { SetProperty(ref data, value); }
        }

        public ICommand RequestCommand { get; private set; }

        public ViewModel()
        {
            RequestCommand = new DelegateCommand<int?>(Request, CanRequest);
        }

        void Request(int? picturesCount)
        {
            Data = null;
            Data = DataProvider.Get(picturesCount.Value);
        }

        bool CanRequest(int? picturesCount)
        {
            return picturesCount.HasValue && picturesCount.Value > 0;
        }
    }
}
