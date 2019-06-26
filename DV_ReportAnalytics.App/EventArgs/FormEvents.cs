using System;
using System.Xml;
using DV_ReportAnalytics.Management;

namespace DV_ReportAnalytics.UI
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

    internal class MessageEventArgs : EventArgs
    {
        public string Message { get; }
        public MessageEventArgs(string message) { Message = message; }
    }

    internal class WizardFinishedEventArgs : EventArgs
    {
        public string File { get; }
        public ReportTypes Type { get; }
        public WizardFinishedEventArgs(string file, ReportTypes type) { File = file; Type = type; }
    }
}