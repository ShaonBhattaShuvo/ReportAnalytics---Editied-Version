using System;
using System.Windows.Forms;
using System.Xml;
using System.ComponentModel;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Views
{
    internal partial class NewFileWizardPage1 : UserControl, IWizardPage
    {
        private FileBrowserWithLabelUpdateEventArgs _result;
        private FileBrowserWithLabelUpdateEventArgs _config;

        public event WizardPageReadyEventHandler WizardPageReady;
        public int PageNumber { get; }
        public bool Ready { get; private set; }

        public NewFileWizardPage1()
        {
            InitializeComponent();
            fileBrowserWithLabelResult.FileBrowserWithLabelUpdate += BrowserUpdate;
            fileBrowserWithLabelConfig.FileBrowserWithLabelUpdate += BrowserUpdate;
            PageNumber = 1;
            Ready = false;
        }

        private void BrowserUpdate(object sender, FileBrowserWithLabelUpdateEventArgs e)
        {
            if (sender == fileBrowserWithLabelResult)
                _result = e;
            else if (sender == fileBrowserWithLabelConfig)
                _config = e;

            if ((_result != null && _config != null) && (_result.OK && _config.OK))
            {
                if (WizardPageReady != null)
                {
                    Ready = true;
                    WizardPageReady.Invoke(this, new WizardPageReadyEventArgs(Ready));
                }
            }
        }

        // generally the first page does not have to preload
        public void Reload(XmlDocument[] docs) { return; }

        public XmlDocument Submit()
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.LoadXml(Properties.Resources.NewFileWizardPage1);
            doc.SetNodeValue("ResultPath", _result.Path);
            doc.SetNodeValue("ConfigPath", _config.Path);
            return doc;
        }
    }
}
