using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DV_ReportAnalytics.Models
{
    interface IEptReportModel : ISpreadSheetModel
    {
        string[] Names { get; }
        // new pattern should be re-instantiated
        Regex Pattern { set; get; }
        // column index for name field
        int IndexName { set; get; }
        // column index for value field
        int IndexValue { set; get; }
        // 
    }
}
