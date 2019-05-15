using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IBaseController
    {
        event Action<object, ContentUpdateEventArgs> ContentUpdated;
    }
}
