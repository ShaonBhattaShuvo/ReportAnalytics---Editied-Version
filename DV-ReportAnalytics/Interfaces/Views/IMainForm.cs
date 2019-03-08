using System;

namespace DV_ReportAnalytics.Views
{
    internal interface IMainForm
    {
        // open file in workbookview component
        void OpenWorkbookView(string path);

        // update current workbookview component
        void UpdateWorkbookView(byte[] buffer);
    }
}
