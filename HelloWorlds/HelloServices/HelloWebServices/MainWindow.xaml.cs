using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelloWebServices.Services.Msdn.Microsoft;

namespace HelloWebServices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Use the ContentService (web service)
            // Set up a request object
            getContentRequest request = new getContentRequest();
            request.contentIdentifier = "abhtw0f1";

            // Create the client
            ContentServicePortTypeClient client = new ContentServicePortTypeClient();

            this.DataContext = client.GetContent(new appId(), request);

            
        }
    }
}
