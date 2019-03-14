using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Events
{
    internal class WorkbookOpenEventArgs : EventArgs
    {
        public string Path { get; }
        public bool Done { get; }

        public WorkbookOpenEventArgs(string path, bool done)
        {
            Path = path;
            Done = done;
        }

    }
    internal delegate void WorkbookOpenEventHandler(object sender, WorkbookOpenEventArgs e);


    internal class WorkbookConfigUpdateEventArgs : EventArgs
    {
        public TEptConfig Config { get; }
        public WorkbookConfigUpdateEventArgs(TEptConfig config)
        {
            Config = config;
        }
    }

    internal delegate void WorkbookConfigUpdateEventHandler(object sender, WorkbookConfigUpdateEventArgs e);


    internal class WorkbookUpdateEventArgs : EventArgs
    {
        // the whole excel file in binary
        public byte[] Buffer { get; }
        public WorkbookUpdateEventArgs(byte[] buffer)
        {
            Buffer = buffer;
        }
    }

    internal delegate void WorkbookUpdateEventHandler(object sender, WorkbookUpdateEventArgs e);
}
