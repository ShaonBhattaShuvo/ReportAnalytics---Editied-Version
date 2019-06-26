using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DV_ReportAnalytics
{
    internal enum ReportTypes : int
    {
        None = 0,
        EPTReport
    };

    internal static class ReportInstanceManager
    {
        private static Dictionary<ReportTypes, Func<string, BaseReportPresenter>> Registry = 
            new Dictionary<ReportTypes, Func<string, BaseReportPresenter>>
        {
                { ReportTypes.EPTReport, (string file) => new EPTReportPresenter(file) }
        };

        public static BaseReportPresenter CreateNewReport(ReportTypes type, string file)
        {
            return Registry[type](file);
        }

    }
}
