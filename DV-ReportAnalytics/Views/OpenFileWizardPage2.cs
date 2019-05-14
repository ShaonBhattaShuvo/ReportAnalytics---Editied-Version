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
    internal partial class OpenFileWizardPage2 : UserControl, IWizardPage, IBaseControl
    {
        private IBaseControl _processPanel;
        public event Action<object, FormUpdateEventArgs> ContentsUpdated;
        public int PageNumber { get; } = 2;

        public XmlDocument Contents
        {
            set
            {
                // update from page 1
                ModelTypes t = value.GetNodeValue("Type").ToModelTypes();
                Controls.Clear(); // clear before show new view
                _processPanel.Dispose();
                switch (t)
                {
                    case ModelTypes.EPTReport:
                        _processPanel = new ProcessPanels.EPTProcessPanel();
                        
                        break;
                    default:
                        break;
                }
                _processPanel?.Contents = value;
                _processPanel?.Dock = DockStyle.Fill;
                Controls.Add((UserControl)_processPanel);
                _processPanel?.Show();
            }
            get { return _processPanel.Contents; }
        }


        public OpenFileWizardPage2()
        {
            InitializeComponent();
        }

        private void InitializeClass()
        {

        }
    }
}
