using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.UI
{
        public class UserMessageEventArgs : EventArgs
        {
            public string Message { get; }

            public UserMessageEventArgs(string message)
            {
                this.Message = message;
            }

        }
        public delegate void UserMessageEventHandler(object sender, UserMessageEventArgs e);
        
}
