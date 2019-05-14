using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IEptConfigForm : IBaseControl
    {
        // provide an event for controller to subscribe
        event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;
    }
}
