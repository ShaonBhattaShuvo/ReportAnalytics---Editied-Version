using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IWorkbookModelController
    {
        event WorkbookOpenEventHandler WorkbookOpen;
        //void SetWorkbookView(IWorkbook workbook);
        void OpenModelView();
    }
}
