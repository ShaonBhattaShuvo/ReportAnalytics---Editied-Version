using System;
using System.Windows.Forms;
using System.Xml;

namespace DV_ReportAnalytics
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
                PathResult = value.GetNodeValue("Paths/Result");
                PathConfig = value.GetNodeValue("Paths/Config");
            }
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Properties.Resources.Path);
                doc.SetNodeValue("Paths/Result", PathResult);
                doc.SetNodeValue("Paths/Config", PathConfig);
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
