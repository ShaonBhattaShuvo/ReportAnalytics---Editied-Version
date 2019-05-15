using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IBaseController
    {
        event Action<object, ContentUpdateEventArgs> ContentUpdated;
    }
}
