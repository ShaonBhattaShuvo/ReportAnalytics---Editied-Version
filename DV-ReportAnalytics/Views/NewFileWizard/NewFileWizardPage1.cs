using System;
using System.Windows.Forms;
using System.Xml;
using System.ComponentModel;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal partial class NewFileWizardPage1 : UserControl, INewFileWizardPage
    {
        private FileBrowserWithLabelUpdateEventArgs _result;
        private FileBrowserWithLabelUpdateEventArgs _config;
        public event NewFileWizardPageReadyEventHandler NewFileWizardPageReady;
        public int PageNumber { get; }
        public XmlDocument Doc { get; }
        public string Template { get; } =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
            "<Paths>\n" +
            "   <ResultPath></ResultPath>\n" +
            "   <ConfigPath></ConfigPath>\n" +
            "</Paths>";

        public NewFileWizardPage1()
        {
            InitializeComponent();
            fileBrowserWithLabelResult.FileBrowserWithLabelUpdate += BrowserUpdate;
            fileBrowserWithLabelConfig.FileBrowserWithLabelUpdate += BrowserUpdate;
            Doc = new XmlDocument();
            Doc.PreserveWhitespace = true;
            Doc.LoadXml(Template);
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
                Doc.DocumentElement.SelectSingleNode("ResultPath").InnerText = _result.Path;
                Doc.DocumentElement.SelectSingleNode("ConfigPath").InnerText = _config.Path;
                if (NewFileWizardPageReady != null)
                {
                    NewFileWizardPageReady.Invoke(this, new NewFileWizardPageReadyEventArgs(Doc, true));
                }
            }
        }

        // generally the first page does not have to preload
        public void Reload(XmlDocument[] docs) { return; }
    }
}
