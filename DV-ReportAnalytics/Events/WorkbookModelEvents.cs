using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace DV_ReportAnalytics.Events
{
    class WorkbookModelViewSubmitEvent : EventArgs
    {
        public XmlDocument Config { get; }
        public WorkbookModelViewSubmitEvent(XmlDocument config)
        {
            Config = config;
        }
    }

    delegate void WorkbookModelViewSubmitEventHandler(object sender, WorkbookModelViewSubmitEvent e);

    class WorkbookModelUpdateEvent : EventArgs
    {
        // the whole excel file in binary
        public byte[] Buffer { get; }
        public WorkbookModelUpdateEvent(byte[] buffer)
        {
            Buffer = buffer;
        }
    }

    delegate void WorkbookModelUpdateEventHandler(object sender, WorkbookModelUpdateEvent e);
}
