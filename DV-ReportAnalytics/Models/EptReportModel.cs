using System;
using System.Text.RegularExpressions;

namespace DV_ReportAnalytics.Models
{
    class EptReportModel: SpreadSheetModel, IEptReportModel
    {
        public string[] Names { get; }
        public Regex Pattern { set; get; }
        public int NameIndex { set; get; }
        public int ValueIndex { set; get; }

        public EptReportModel(string path): base(path)
        {

        }

        public override void Open()
        {

        }
    }
}
