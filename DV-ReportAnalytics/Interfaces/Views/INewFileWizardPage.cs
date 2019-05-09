using System;
using System.Xml;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface INewFileWizardPage
    {
        event NewFileWizardPageReadyEventHandler NewFileWizardPageReady;
        int PageNumber { get; }
        string Template { get; }
        XmlDocument Doc { get; }
        // load page according to previous pages
        void Reload(XmlDocument[] docs);

        // UserControl members
        DockStyle Dock { set; get; }
        void Show();
    }
}
