using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Models;
using SpreadsheetGear;

namespace DV_ReportAnalytics.Controllers
{
    interface IWorkbookModelController
    {
        string FileName { get; }
        string FilePath { get; }
        //void SetWorkbookView(IWorkbook workbook);
        void Refresh();
        void OpenModelView();
    }
}
