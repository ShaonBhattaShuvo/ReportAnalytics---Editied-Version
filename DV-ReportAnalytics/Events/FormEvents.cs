using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DV_ReportAnalytics.Events
{
    internal class FormUpdateEventArgs : EventArgs
    {
        public XmlDocument Content { get; } = null;
        public string Message { get; } = null;
        public FormUpdateEventArgs() { }
        public FormUpdateEventArgs(XmlDocument content) { Content = content; }
        public FormUpdateEventArgs(string message) { Message = message; }
        public FormUpdateEventArgs(XmlDocument content, string message) { Content = content; Message = message; }
    }
}
