using System;
using System.Xml;

namespace DV_ReportAnalytics.Events
{
    class WorkbookOpenEventArgs : EventArgs
    {
        public string Path { get; }

        public WorkbookOpenEventArgs(string path)
        {
            Path = path;
        }

    }
    delegate void WorkbookOpenEventHandler(object sender, WorkbookOpenEventArgs e);

    class WorkbookConfigUpdateEventArgs : EventArgs
    {
        public XmlDocument Config { get; }
        public WorkbookConfigUpdateEventArgs(XmlDocument config)
        {
            Config = config;
        }
    }

    delegate void WorkbookConfigUpdateEventHandler(object sender, WorkbookConfigUpdateEventArgs e);

    class WorkbookUpdateEventArgs : EventArgs
    {
        // the whole excel file in binary
        public byte[] Buffer { get; }
        public WorkbookUpdateEventArgs(byte[] buffer)
        {
            Buffer = buffer;
        }
    }

    delegate void WorkbookUpdateEventHandler(object sender, WorkbookUpdateEventArgs e);
}
