using System;
using System.Text.RegularExpressions;

namespace DV_ReportAnalytics.Models
{
    internal interface IEptReportModel : IWorkbookModel
    {
        
        // new pattern should be re-instantiated
        Regex ResultFormat { set; get; }
        // search column index
        int SearchIndexName { set; get; }
        int SearchIndexValue { set; get; }
        string Name { set; get; }
        string InputSheetName { set; get; }
        string OutputSheetName { set; get; }
        string[] Names { get; }
    }
}
