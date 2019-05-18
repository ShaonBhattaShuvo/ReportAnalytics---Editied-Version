using System;
using System.Xml;

namespace DV_ReportAnalytics
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
