using System;

namespace DV_ReportAnalytics.Events
{
    public class DataPlotEventArgs: EventArgs
    {
        public string Data {get;}

        public DataPlotEventArgs(string data)
        {
            Data = data;
        }
    }
    public delegate void DataPlotEventHandler(object sender, DataPlotEventArgs e);
}
