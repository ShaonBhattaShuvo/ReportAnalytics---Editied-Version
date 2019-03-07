using System;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal partial class EptForm : Form, IWorkbookModelView
    {
        public event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;

        public EptForm()
        {
            InitializeComponent();
        }
    }
}
