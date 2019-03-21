using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IEptReportController : IWorkbookModelController
    {
        // name of the report
        string Name { get; set; }
        string InputSheetName { set; get; }
        string OutputSheetName { set; get; }
        string ResultFormat { set; get; }
    }
}
