using System;
using System.Xml;
using System.Collections.Generic;

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
        public XmlDocument Config { get; }
        public WorkbookConfigUpdateEventArgs(XmlDocument config)
        {
            Config = config; 
        }
    }

    internal delegate void WorkbookConfigUpdateEventHandler(object sender, WorkbookConfigUpdateEventArgs e);


    internal class WorkbookTableUpdateEventArgs : EventArgs
    {
        public string[] TableNames;
        public WorkbookTableUpdateEventArgs(string[] names)
        {
            TableNames = names;
        }
    }

    internal delegate void WorkbookTableUpdateEventHandler(object sender, WorkbookTableUpdateEventArgs e);
}
