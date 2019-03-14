using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

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
        int SpeedInterp { set; get; }
        int TorqueInterp { set; get; }
        // indicate table names and enabled status in sheet
        Dictionary<string, bool> TableNames { get; }

        TEptConfig GetConfig();
    }
}
