using System;

namespace DV_ReportAnalytics.Models
{
    class EptReport: SpreadSheetModel, IEptReport
    {
        public EptReport(string path): base(path)
        {

        }

        public override void Open()
        {

        }
    }
}
