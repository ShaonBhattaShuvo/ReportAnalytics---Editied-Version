using System;

namespace DV_ReportAnalytics.Events
{
    class DataPlotEventArgs: EventArgs
    {
        public string Data {get;}

        public DataPlotEventArgs(string data)
        {
            Data = data;
        }
    }
    delegate void DataPlotEventHandler(object sender, DataPlotEventArgs e);
}
