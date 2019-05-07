using System;
using System.Xml;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal partial class ProcessConfigForm : Form, IProcessConfigForm
    {
        public event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;

        public ProcessConfigForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // TODO: invoke will be removed in the future
            if (WorkbookConfigUpdate != null)
            {
                WorkbookConfigUpdate.Invoke(this, new WorkbookConfigUpdateEventArgs(new XmlDocument()));
            }
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (WorkbookConfigUpdate != null)
            {
                WorkbookConfigUpdate.Invoke(this, new WorkbookConfigUpdateEventArgs(new XmlDocument()));
            }
            Close();
        }
    }
}
