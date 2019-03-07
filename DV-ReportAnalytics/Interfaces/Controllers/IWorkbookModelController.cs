using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    interface IWorkbookModelController
    {
        event WorkbookOpenEventHandler WorkbookOpen;
        //void SetWorkbookView(IWorkbook workbook);
        void OpenModelView();
    }
}
