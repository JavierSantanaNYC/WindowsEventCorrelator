using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace WindowsEventCorrelator
{
    public partial class WindowsEventCorrelator : ServiceBase
    {

        public WindowsEventCorrelator()
        {
            InitializeComponent();
            eventLog1 = new EventLog("Application");
            
            fileSystemWatcher1 = new System.IO.FileSystemWatcher(@"C:\Windows", "*.sys");
            
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
