using System;
using System.Windows.Forms;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public partial class SettingsForm : Form, IView
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        public event EventHandler RequestClosed; // not necessary for this form
        
        public void BindData(object source)
        {
            var control = (Control)source;
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(control);
        }

        public void Close()
        {
            ((IView)panelContent.Controls[0]).Close();
            base.Close();
        }
    }
}
