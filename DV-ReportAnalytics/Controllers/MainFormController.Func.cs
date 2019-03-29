using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Constant;
using DV_ReportAnalytics.Extensions;
using SpreadsheetGear.Windows.Forms;

namespace DV_ReportAnalytics.Controllers
{
    internal partial class MainFormController : IMainFormController
    {
        // ------public------


        // ------private------
        private void InitModelController()
        {
            // TODO: change type dynamically
            //string type = _processConfig.GetNodeValue("Type");
            string type = "EptReport";
            // convert string to corresponding type
            if (Enum.TryParse<ModelTypes>(type, false, out ModelTypes t))
            {
                // avoid multiple instances being initiated
                if (_currentModel != t)
                {
                    // new type initiated
                    _currentModel = t;
                    switch (_currentModel)
                    {
                        case ModelTypes.EptReport:
                            _workbookModelController = new EptReportController(_mainForm);
                            break;
                        default:
                            break;
                    }
                }
                //_workbookModelController.SetProcessConfig(_processConfig);
            }
            else
            {
                throw new Exception("Invalid type!");
            }
        }
    }
}
