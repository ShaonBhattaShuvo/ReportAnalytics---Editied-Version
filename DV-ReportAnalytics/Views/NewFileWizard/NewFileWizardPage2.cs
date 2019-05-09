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
    internal partial class NewFileWizardPage2 : UserControl, IWizardPage
    {
        public event WizardPageReadyEventHandler WizardPageReady;
        public int PageNumber { get; }

        private IProcessPanel _processPanel;
        private XmlDocument _doc;

        public NewFileWizardPage2()
        {
            InitializeComponent();
            _doc = new XmlDocument();
            _doc.PreserveWhitespace = true;
            PageNumber = 2;
        }

        public void Reload(XmlDocument[] docs)
        {
            // update from page 1
            XmlNode root = (XmlNode)docs[1].DocumentElement;
            _doc.Load(root.SelectSingleNode("Paths/ConfigPath").InnerText);
        }

        public XmlDocument Submit()
        {
            return _processPanel.Submit();
        }
    }
}
