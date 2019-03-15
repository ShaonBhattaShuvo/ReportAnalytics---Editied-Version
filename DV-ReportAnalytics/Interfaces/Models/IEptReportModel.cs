using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Models
{
    internal interface IEptReportModel : IWorkbookModel
    {
        // regex pattern
        string ResultFormat { set; get; }
        string[] TableNames { get; }
        // search column index
        int SearchNameIndex { set; get; }
        int SearchValueIndex { set; get; }
        string Name { set; get; }
        string InputSheetName { set; get; }
        string OutputSheetName { set; get; }
        int SpeedInterp { set; get; }
        int TorqueInterp { set; get; }
        EptTable this[string tableName] { get; }

        TEptConfig GetConfig();
    }
}
