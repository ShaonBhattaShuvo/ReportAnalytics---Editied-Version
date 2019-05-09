using System;
using System.Xml;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IWizardPage
    {
        event WizardPageReadyEventHandler WizardPageReady;
        int PageNumber { get; }
        bool Ready { get; }
        // load page according to previous pages
        void Reload(XmlDocument[] docs);
        XmlDocument Submit();

        // UserControl members
        DockStyle Dock { set; get; }
        void Show();
    }
}
