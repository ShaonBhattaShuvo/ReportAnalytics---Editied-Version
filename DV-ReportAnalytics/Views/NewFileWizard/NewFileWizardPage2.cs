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
using DV_ReportAnalytics.Extensions;
using DV_ReportAnalytics.Constants;

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
            _doc.Load(docs[1].GetNodeValue("Paths/ConfigPath"));
            ModelTypes t = _doc.GetNodeValue("Type").ToModelTypes();
            switch (t)
            {
                case ModelTypes.EPTReport:
                    _processPanel = new ProcessPanels.EPTProcessPanel();
                    _processPanel.Reload(_doc);
                    _processPanel.Dock = DockStyle.Fill;
                    break;
                default:
                    break;
            }
        }

        public XmlDocument Submit()
        {
            return _processPanel.Submit();
        }
    }
}
