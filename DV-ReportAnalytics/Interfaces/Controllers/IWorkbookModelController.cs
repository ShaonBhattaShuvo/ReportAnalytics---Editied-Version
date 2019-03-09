using System;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IWorkbookModelController<TMainForm>
        where TMainForm : IMainForm
    {
        // open window to make configurations
        void ShowModelView();

        // when path changes update model file
        void OpenModel(string path);

        // set worbookview component
        void SetMainView(TMainForm mainForm);
    }
}
