using System;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IWorkbookModelController
    {
        // open window to make configurations
        void OpenModelView();

        // when path changes update model file
        void UpdateModel(string path);

        // set worbookview component
        void SetMainView(IMainForm main);
    }
}
