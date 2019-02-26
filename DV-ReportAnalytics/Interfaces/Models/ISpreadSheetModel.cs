using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    interface ISpreadSheetModel
    {
        string FileName {get;}
        string FilePath {get;}
        // open file
        void Open(); 
    }
}
