using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    public interface ISpreadSheetModel
    {
        string FileName {get;}
        string FilePath {get;}
        event FileOpenEventHandler FileOpen;
        event DataPlotEventHandler DataPlot;
        void Open(); // open file
        void GetPlotData();
    }
}
