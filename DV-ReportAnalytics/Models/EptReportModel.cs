using System;

namespace DV_ReportAnalytics.Models
{
    class EptReportModel: SpreadSheetModel, IEptReportModel
    {
        public string[] Names { get; }


        public EptReportModel(string path): base(path)
        {

        }

        public override void Open()
        {

        }
    }
}
