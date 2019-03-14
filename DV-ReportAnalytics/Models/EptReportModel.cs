using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    internal class EptReportModel : WorkbookModel, IEptReportModel
    {
        public Dictionary<string, bool> TableNames { get; }
        public string Name { set; get; }
        public string InputSheetName { set; get; }
        public string OutputSheetName { set; get; }
        public Regex ResultFormat { set; get; }
        public int SearchIndexName { set; get; }
        public int SearchIndexValue { set; get; }
        public int SpeedInterp { set; get; }
        public int TorqueInterp { set; get; }

        public EptReportModel(): base()
        {

        }

        public TEptConfig GetConfig()
        {
            return new TEptConfig(TableNames, SpeedInterp, TorqueInterp);
        }

        public void Debug()
        {
            Console.WriteLine("Count: {0}", _application.Workbooks.Count);

        }
    }
}
