using System;
using System.Text.RegularExpressions;

namespace DV_ReportAnalytics.Models
{
    internal interface IEptReportModel : ISpreadSheetModel
    {
        string[] Names { get; }
        // new pattern should be re-instantiated
        Regex Pattern { set; get; }
        // column index for name field
        int NameIndex { set; get; }
        // column index for value field
        int ValueIndex { set; get; }
        // 
    }
}
