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


    internal class WorkbookDisplaySettingsUpdateEventArgs : EventArgs
    {
        public XmlDocument Settings { get; }
        public WorkbookDisplaySettingsUpdateEventArgs(XmlDocument settings)
        {
            Settings = settings; 
        }
    }

    internal delegate void WorkbookDisplaySettingsUpdateEventHandler(object sender, WorkbookDisplaySettingsUpdateEventArgs e);


    internal class WorkbookTableUpdateEventArgs<T> : EventArgs
    {
        public Dictionary<string, T> Tables { get; }
        public WorkbookTableUpdateEventArgs(Dictionary<string, T> tables)
        {
            Tables = tables;
        }
    }

    internal delegate void WorkbookTableUpdateEventHandler<T>(object sender, WorkbookTableUpdateEventArgs<T> e);
}
