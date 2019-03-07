using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IWorkbookModelView
    {
        // provide an event for controller to subscribe
        event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;
        void Show();
    }
}
