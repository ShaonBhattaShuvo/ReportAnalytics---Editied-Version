using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Constant;

namespace DV_ReportAnalytics.Controllers
{
    internal partial class MainFormController : IMainFormController
    {
        private void _GetModelControllerType(string type)
        {
            // convert string to corresponding type
            if (Enum.TryParse<ModelTypes>(type, false, out ModelTypes t))
            {
                // avoid multiple instance initiated
                if (_currentModel != t)
                {
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
            }
            else
            {
                throw new Exception("Invalid type!");
            }
        }
    }
}
