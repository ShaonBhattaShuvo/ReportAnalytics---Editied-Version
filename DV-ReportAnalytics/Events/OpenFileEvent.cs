using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Events
{
        public class OpenFileEventArgs : EventArgs
        {
            public string Message { get; }

            public OpenFileEventArgs(string message)
            {
                this.Message = message;
            }

        }
        public delegate void OpenFileEventHandler(object sender, OpenFileEventArgs e);
        
}
