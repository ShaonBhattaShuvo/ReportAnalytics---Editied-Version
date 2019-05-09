using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DV_ReportAnalytics.Events
{
    internal class WizardPageReadyEventArgs : EventArgs
    {
        public bool OK { get; }
        public WizardPageReadyEventArgs(bool ok)
        {
            OK = ok;
        }
    }
    internal delegate void WizardPageReadyEventHandler(object sender, WizardPageReadyEventArgs e);

    internal class WizardFinishEventArgs : EventArgs
    {
        public XmlDocument[] Config { get; }
        public WizardFinishEventArgs(XmlDocument[] config)
        {
            Config = config;
        }
    }
    internal delegate void WizardFinishEventHandler(object sender, WizardFinishEventArgs e);
}
