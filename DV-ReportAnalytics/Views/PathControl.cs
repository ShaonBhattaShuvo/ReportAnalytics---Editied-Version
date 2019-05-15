using System;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Views
{
    internal partial class PathControl : UserControl, IBaseControl
    {
        public event Action<object, ContentUpdateEventArgs> ContentUpdated;

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
                PathResult = value.GetNodeValue("Paths/PathResult");
                PathConfig = value.GetNodeValue("Paths/PathConfig");
            }
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.LoadXml(Properties.Resources.Path);
                doc.SetNodeValue("Paths/PathResult", PathResult);
                doc.SetNodeValue("Paths/PathConfig", PathConfig);
                return doc;
            }
        }

        public PathControl()
        {
            InitializeComponent();

            fileBrowserWithLabelResult.ContentUpdated += (object sender, ContentUpdateEventArgs e) => UpdateFromBrowser();
            fileBrowserWithLabelConfig.ContentUpdated += (object sender, ContentUpdateEventArgs e) => UpdateFromBrowser();
            fileBrowserWithLabelResult.EnableTextBox = false;
            fileBrowserWithLabelConfig.EnableTextBox = false;
        }

        private void UpdateFromBrowser()
        {
            if (!(string.IsNullOrWhiteSpace(PathResult)) && !(string.IsNullOrWhiteSpace(PathConfig)))
                ContentUpdated?.Invoke(this, new ContentUpdateEventArgs(Content, "Paths"));
        }
    }
}
