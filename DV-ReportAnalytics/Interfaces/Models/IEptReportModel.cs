using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    internal interface IEptReportModel : IWorkbookModel<TEptData3>
    {
        EptTable this[string tableName] { get; set; }
        Dictionary<string, TEptData3> GetData(int rowInterp, int colInterp);
        Dictionary<string, TEptData3> GetData(string[] names, int rowInterp, int colInterp);
    }
}
