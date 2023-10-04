using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace asyncLove
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string url = @"https://www.youtube.com/";
        WebClient webClient = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SimpleDownload(object sender, RoutedEventArgs e)
        {
            var txt = webClient.DownloadString(url);
            //for (int i = 0; i < 10; i++)
            //{
            //    txt += webClient.DownloadString(url);
            //}
            txtBox.Text = txt;

        }


        private void DontClick(object sender, RoutedEventArgs e)
        {
            var tsk = webClient.DownloadStringTaskAsync(url);
            txtBox.Text = tsk.Result;
        }

        private void TaskDownload(object sender, RoutedEventArgs e)
        {
            var tsk = webClient.DownloadStringTaskAsync(url)
            .ContinueWith(t =>
             {
                 txtBox.Text = t.Result;
             }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void TaskContext(object sender, RoutedEventArgs e)
        {
            var context = SynchronizationContext.Current;
            var tsk = webClient.DownloadStringTaskAsync(url)
                .ContinueWith(t =>
                {
                    context.Send(_ =>
                    {
                        txtBox.Text = t.Result;
                    }, null);
                });
        }

        private async void AwaitDownload(object sender, RoutedEventArgs e)
        {
            var txt = await webClient.DownloadStringTaskAsync(url);
            txtBox.Text = txt;
        }

        private void ClearMethod(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
        }
    }
}
