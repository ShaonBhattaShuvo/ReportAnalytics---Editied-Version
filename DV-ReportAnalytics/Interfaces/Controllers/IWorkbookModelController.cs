using System;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IWorkbookModelController
    {
        // open window to make configurations
        void ShowModelView();

        // when workbookview changes update model file
        void RefreshModel();

        // save to file
        void Export(string path);
    }
}
