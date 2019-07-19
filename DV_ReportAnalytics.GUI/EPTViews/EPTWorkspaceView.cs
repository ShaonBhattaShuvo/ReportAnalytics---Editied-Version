using System;
using System.Windows.Forms;
using SpreadsheetGear.Windows.Forms;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public partial class EPTWorkspaceView : UserControl, IEPTWorkspaceView
    {
        public EPTWorkspaceView()
        {
            InitializeComponent();
        }

        #region IEPTWorkspaceView member
        public WorkbookView WorkbookView => workbookView1;
        #endregion

        public event EventHandler RequestClosed;
        
        public void Close()
        {
            RequestClosed?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

        public void BindData(object source)
        {
            // not necessary for this control
        }
    }
}
