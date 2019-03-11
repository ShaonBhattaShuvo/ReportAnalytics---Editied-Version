﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Models;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Constant;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    internal partial class MainFormController : IMainFormController
    {
        private void _GetType(string type)
        {
            if (Enum.TryParse<ModelTypes>(type, false, out ModelTypes t))
            {
                switch (t)
                {
                    case ModelTypes.EptReport:
                        _workbookModelController = new EptReportController(_mainForm);
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
