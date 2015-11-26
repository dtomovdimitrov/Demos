using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace HelloCustomWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    text.Text = "clicked";
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(2000);
        //        Dispatcher.BeginInvoke(new Action(() =>
        //        {
        //            text.Text = null;
        //        }));
        //    });
        //}

        //private void CustomControl1_Click(object sender, RoutedEventArgs e)
        //{
        //    text.Text = "clicked 2";
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(2000);
        //        Dispatcher.BeginInvoke(new Action(() =>
        //        {
        //            text.Text = null;
        //        }));
        //    });
        //}
    }
}
