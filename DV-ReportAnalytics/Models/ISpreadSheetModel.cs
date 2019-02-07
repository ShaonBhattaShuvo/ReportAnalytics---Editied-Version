using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    public interface ISpreadSheetModel
    {
        string FileName {get;}
        string FilePath {get;}
        event OpenFileEventHandler OpenFile;
        void Open();
    }
}
