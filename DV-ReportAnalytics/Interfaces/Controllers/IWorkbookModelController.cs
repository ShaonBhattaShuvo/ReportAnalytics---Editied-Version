using System;
using System.Xml;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IWorkbookModelController
    {
        // open window to make configurations
        void ShowModelView();

        // define how should the controller process data
        void SetProcessConfig(XmlDocument config);
    }
}
