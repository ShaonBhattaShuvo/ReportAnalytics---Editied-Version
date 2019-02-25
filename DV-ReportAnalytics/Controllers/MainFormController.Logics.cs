using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Models;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    partial class MainFormController
    {
        private IMainForm _view;
        private ISpreadSheetModel _model; // objetc?
        private enum _types : int { EptReport };

        private void getModel(string type, string path)
        {
            if (Enum.TryParse<_types>(type, false, out _types t))
            {
                switch (t)
                {
                    case _types.EptReport:
                        // do something
                        break;
                    default:
                        break;

                }
            }
            else
            {
                // throw exception
            }
        }
    }
}
