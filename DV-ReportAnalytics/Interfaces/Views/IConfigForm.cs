using System;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IConfigForm
    {
        // provide an event for controller to subscribe
        event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;

        // form control function: show window
        void Show();

        DialogResult ShowDialog();
    }
}
