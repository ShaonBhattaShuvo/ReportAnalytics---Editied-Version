using System;
using System.Windows.Forms;
using System.Xml;
using System.ComponentModel;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal partial class NewFileWizardPage1 : UserControl, IWizardPage
    {
        private FileBrowserWithLabelUpdateEventArgs _result;
        private FileBrowserWithLabelUpdateEventArgs _config;
        public event WizardPageReadyEventHandler WizardPageReady;
        public int PageNumber { get; }

        public NewFileWizardPage1()
        {
            InitializeComponent();
            fileBrowserWithLabelResult.FileBrowserWithLabelUpdate += BrowserUpdate;
            fileBrowserWithLabelConfig.FileBrowserWithLabelUpdate += BrowserUpdate;
            PageNumber = 1;
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
                    WizardPageReady.Invoke(this, new WizardPageReadyEventArgs(true));
                }
            }
        }

        // generally the first page does not have to preload
        public void Reload(XmlDocument[] docs) { return; }

        public XmlDocument Submit()
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load(Properties.Resources.NewFileWizardPage1);
            doc.DocumentElement.SelectSingleNode("ResultPath").InnerText = _result.Path;
            doc.DocumentElement.SelectSingleNode("ConfigPath").InnerText = _config.Path;
            return doc;
        }
    }
}
