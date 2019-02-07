using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    interface IMainForm
    {
        void OpenFileHandler(object sender, OpenFileEventArgs args);
        string GetPathFromDialog();
    }
}
