using System;
using System.Windows.Forms;
using System.Xml;
using System.ComponentModel;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Views
{
    internal partial class OpenFileWizardPage1 : UserControl, IWizardPage, IBaseControl
    {
        public event Action<object, FormUpdateEventArgs> ContentUpdated;
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
        public XmlDocument Content
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
                doc.LoadXml(Properties.Resources.Path);
                doc.SetNodeValue("PathResult", PathResult);
                doc.SetNodeValue("PathConfig", PathConfig);
                return doc;
            }
        }

        public OpenFileWizardPage1()
        {
            InitializeComponent();
            fileBrowserWithLabelResult.ContentUpdated += (object sender, FormUpdateEventArgs e) => UpdateFromBrowser();
            fileBrowserWithLabelConfig.ContentUpdated += (object sender, FormUpdateEventArgs e) => UpdateFromBrowser();
        }

        private void UpdateFromBrowser()
        {
            if (string.IsNullOrWhiteSpace(PathResult) || string.IsNullOrWhiteSpace(PathConfig))
                ContentUpdated?.Invoke(this, new FormUpdateEventArgs("false"));
            else
                ContentUpdated?.Invoke(this, new FormUpdateEventArgs(Content, "true"));
        }
    }
}
