using System;
using System.Text.RegularExpressions;

namespace DV_ReportAnalytics.Models
{
    internal class EptReportModel : WorkbookModel, IEptReportModel
    {
        public string[] Names { get; }
        public string Name { set; get; }
        public string InputSheetName { set; get; }
        public string OutputSheetName { set; get; }
        public Regex ResultFormat { set; get; }
        public int SearchIndexName { set; get; }
        public int SearchIndexValue { set; get; }

        public EptReportModel(): base()
        {

        }
    }
}
