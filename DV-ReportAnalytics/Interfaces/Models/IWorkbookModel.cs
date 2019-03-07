using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    interface IWorkbookModel
    {
        string FileName { get; }
        string FilePath { get; }
        // provide an event for controller to subscribe
        event WorkbookUpdateEventHandler WorkbookUpdate;
        // open file
        void Update(WorkbookConfigUpdateEventArgs e);
    }
}
