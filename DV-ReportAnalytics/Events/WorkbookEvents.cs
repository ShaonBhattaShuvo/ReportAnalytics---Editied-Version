using System;
using System.Xml;

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


    internal class WorkbookDisplayUpdateEventArgs : EventArgs
    {
        public XmlDocument Settings { get; }
        public WorkbookDisplayUpdateEventArgs(XmlDocument settings)
        {
            Settings = settings; 
        }
    }

    internal delegate void WorkbookDisplayUpdateEventHandler(object sender, WorkbookDisplayUpdateEventArgs e);


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
