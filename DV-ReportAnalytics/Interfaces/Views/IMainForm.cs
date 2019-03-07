using System;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Views
{
    internal interface IMainForm
    {
        // register model and events here
        void SetModel(ISpreadSheetModel model);
    }
}
