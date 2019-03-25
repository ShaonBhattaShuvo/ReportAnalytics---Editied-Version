using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IEptReportController : IWorkbookModelController
    {
        string Name { get; }
        string Type { get; }
        string InputSheetName { get; }
        string OutputSheetName { get; }
        string ResultFormat { get; }
    }
}
