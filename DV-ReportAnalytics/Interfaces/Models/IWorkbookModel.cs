using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    interface IWorkbookModel
    {
        // provide an event for controller to subscribe
        event WorkbookModelUpdateEventHandler WorkbookModelUpdate;
        // open file
        void UpdateFromModelView(WorkbookModelViewSubmitEvent e);
    }
}
