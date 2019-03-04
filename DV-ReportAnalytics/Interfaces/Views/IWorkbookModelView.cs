using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Interfaces.Views
{
    interface IWorkbookModelView
    {
        // provide an event for controller to subscribe
        event WorkbookModelViewSubmitEventHandler WorkbookModelViewSubmit;
    }
}
