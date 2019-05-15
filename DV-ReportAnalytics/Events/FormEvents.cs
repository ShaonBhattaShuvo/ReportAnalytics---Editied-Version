using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DV_ReportAnalytics.Events
{
    internal class ContentUpdateEventArgs : EventArgs
    {
        public XmlDocument Content { get; } = null;
        public string Message { get; } = null;
        public ContentUpdateEventArgs() { }
        public ContentUpdateEventArgs(XmlDocument content) { Content = content; }
        public ContentUpdateEventArgs(string message) { Message = message; }
        public ContentUpdateEventArgs(XmlDocument content, string message) { Content = content; Message = message; }
    }
}
