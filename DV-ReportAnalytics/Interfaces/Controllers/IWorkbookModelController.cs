using System;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IWorkbookModelController
    {
        // open window to make configurations
        void ShowModelView();

        // save to file
        void Export(string path);
    }
}
