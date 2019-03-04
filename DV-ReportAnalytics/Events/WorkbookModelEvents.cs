using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Events
{
    class WorkbookModelViewSubmitEvent : EventArgs
    {
    }

    delegate void WorkbookModelViewSubmitEventHandler(object sender, WorkbookModelViewSubmitEvent e);

    class WorkbookModelUpdateEvent : EventArgs
    {

    }

    delegate void WorkbookModelUpdateEventHandler(object sender, WorkbookModelUpdateEvent e);
}
