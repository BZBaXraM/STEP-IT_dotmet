using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Processes_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Process process = new Process();
            //process.StartInfo.FileName = "calc";
            //process.Start();
            //process.WaitForExit();        

            InitializeComponent();
            //Process.Start("calc");
            //Process.Start("notepad");
            //Process.Start("mspaint");
            //Process.Start("cmd");
            //Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            //MyText.Text = Process.GetCurrentProcess().PriorityClass.ToString();
            //MyText.Text = Process.GetCurrentProcess().Id.ToString();
            //var pr = Process.GetProcessesByName("msedge");
            var processes = Process.GetProcesses().ToList();

            foreach (var proc in processes)
            {
                processesList.Items.Add($"{proc.Id}. {proc.ProcessName}");
            }
        }
    }
}
