using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    interface IWorkbookModelView
    {
        // provide an event for controller to subscribe
        event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;
        void Show();
    }
}
