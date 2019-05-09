using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DV_ReportAnalytics.Events
{
    internal class NewFileWizardPageReadyEventArgs : EventArgs
    {
        public XmlDocument Doc { get; }
        public bool OK { get; }
        public NewFileWizardPageReadyEventArgs(XmlDocument doc, bool ok)
        {
            Doc = doc;
            OK = ok;
        }
    }
    internal delegate void NewFileWizardPageReadyEventHandler(object sender, NewFileWizardPageReadyEventArgs e);

    internal class NewFileWizardFinishEventArgs : EventArgs
    {
        public XmlDocument Config { get; }
        public NewFileWizardFinishEventArgs(XmlDocument config)
        {
            Config = config;
        }
    }
    internal delegate void NewFileWizardFinishEventHandler(object sender, NewFileWizardFinishEventArgs e);
}
