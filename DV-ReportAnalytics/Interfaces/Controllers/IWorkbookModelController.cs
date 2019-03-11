using System;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IWorkbookModelController
    {
        // open window to make configurations
        void ShowModelView();

        // when path changes update model file
        void OpenModel(string path);

        // set worbookview component
        void SetMainView(IMainForm mainForm);

        // save to file
        void Export(string path);
    }
}
