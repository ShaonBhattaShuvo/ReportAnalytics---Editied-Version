using System;
using System.Windows.Forms;
using System.Xml;
using System.ComponentModel;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Views
{
    internal partial class OpenFileWizardPage1 : UserControl, IWizardPage
    {
        public event Action<object, FormUpdateEventArgs> PageUpdated;
        public int PageNumber { get; } = 1;
        public string PathResult
        {
            get { return fileBrowserWithLabelResult.Path; }
            set { fileBrowserWithLabelResult.Path = value; }
        }
        public string PathConfig
        {
            get { return fileBrowserWithLabelConfig.Path; }
            set { fileBrowserWithLabelConfig.Path = value; }
        }
        public XmlDocument Contents
        {
            set
            {
                PathResult = value.GetNodeValue("PathResult");
                PathConfig = value.GetNodeValue("PathConfig");
            }
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.LoadXml(Properties.Resources.NewFileWizardPage1);
                doc.SetNodeValue("PathResult", PathResult);
                doc.SetNodeValue("PathConfig", PathConfig);
                return doc;
            }
        }

        public OpenFileWizardPage1()
        {
            InitializeComponent();
            InitializeClass();
        }

        private void InitializeClass()
        {
            fileBrowserWithLabelResult.ContentsUpdated += (object sender, FormUpdateEventArgs e) => UpdateFromBrowser();
            fileBrowserWithLabelConfig.ContentsUpdated += (object sender, FormUpdateEventArgs e) => UpdateFromBrowser();
        }

        private void UpdateFromBrowser()
        {
            if (string.IsNullOrWhiteSpace(PathResult) || string.IsNullOrWhiteSpace(PathConfig))
                PageUpdated?.Invoke(this, new FormUpdateEventArgs("false"));
            else
                PageUpdated?.Invoke(this, new FormUpdateEventArgs(Contents, "true"));
        }
    }
}
