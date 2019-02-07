using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Events
{
    class UserMessageEventArgs : EventArgs
    {
        public string Message { get; }

        public UserMessageEventArgs(string message)
        {
            this.Message = message;
        }

    }
    delegate void UserMessageEventHandler(object sender, UserMessageEventArgs e);
        
}
