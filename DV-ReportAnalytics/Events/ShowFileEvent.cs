using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Events
{
        public class ShowFileEventArgs : EventArgs
        {
            public string Path { get; }

            public ShowFileEventArgs(string path)
            {
                this.Path = path;
            }

        }
        public delegate void ShowFileEventHandler(object sender, ShowFileEventArgs e);
        
}
