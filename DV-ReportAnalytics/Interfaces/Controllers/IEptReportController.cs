using System;
using System.Xml;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IEptReportController : IWorkbookModelController
    {
        void SetProcessConfig(XmlDocument config);
    }
}
