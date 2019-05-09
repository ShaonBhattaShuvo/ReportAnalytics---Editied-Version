using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal partial class NewFileWizardPage2 : UserControl, INewFileWizardPage
    {
        public event NewFileWizardPageReadyEventHandler NewFileWizardPageReady;
        public int PageNumber { get; }
        public string Template { get; private set; }
        public XmlDocument Doc { get; private set; }

        public NewFileWizardPage2()
        {
            InitializeComponent();
            Doc = new XmlDocument();
            Doc.PreserveWhitespace = true;
            PageNumber = 2;
        }

        public void Reload(XmlDocument[] docs)
        {
            // update from page 1
            XmlNode root = (XmlNode)docs[1].DocumentElement;
            Doc.Load(root.SelectSingleNode("Paths/ConfigPath").InnerText);
        }
    }
}
