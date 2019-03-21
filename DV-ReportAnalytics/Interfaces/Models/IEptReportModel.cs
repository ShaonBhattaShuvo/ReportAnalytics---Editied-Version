using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    internal interface IEptReportModel : IWorkbookModel<TEptData3>
    {
        // regex pattern
        string SearchPattern { set; get; }
        string[] TableNames { get; }
        // search column index
        int SearchIndexName { set; get; }
        int SearchIndexValue { set; get; }
        EptTable this[string tableName] { get; }
    }
}
