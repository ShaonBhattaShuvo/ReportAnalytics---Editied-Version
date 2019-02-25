using System;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Views
{
    interface IMainForm
    {
        // register model and events here
        void SetModel(ISpreadSheetModel model);
    }
}
