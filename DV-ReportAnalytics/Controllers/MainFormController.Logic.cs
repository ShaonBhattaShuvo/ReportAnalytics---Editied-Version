using System;
using System.Xml;
using DV_ReportAnalytics.Constants;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Extensions;
using SpreadsheetGear;
using SpreadsheetGear.Windows.Forms;

namespace DV_ReportAnalytics.Controllers
{
    internal partial class MainFormController
    {
        private void InitializeModel()
        {
            // avoid multiple instances being initiated
            ModelTypes t = _doc.GetNodeValue("Settings/Type").ToModelTypes();
            string p = _doc.GetNodeValue("Paths/Result");
            switch (_currentModel)
            {
                case ModelTypes.EPTReport:
                    // TODO: new model
                    
                    break;
                default:
                    break;
            }
        }

    }
}
