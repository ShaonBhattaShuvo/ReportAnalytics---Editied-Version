using System;
using System.Windows.Forms;
using SpreadsheetGear.Windows.Forms;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ToolStripButtonSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonSettings_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonTableDisplay_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonGraphToggle_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonHelp_Click(object sender, EventArgs e)
        {

        }

        #region IMainView members
        public event EventHandler OpenClicked;
        public event EventHandler ExportClicked;
        public event EventHandler HelpClicked;
        public event EventHandler SettingsClicked;
        public event EventHandler DisplayClicked;

        public void UpdateWorkspace(object content)
        {
            var control = (Control)content;
            control.Dock = DockStyle.Fill;
            splitContainerMain.Panel1.Controls.Clear();
            splitContainerMain.Panel1.Controls.Add(control);
            ToggleButtonsEnabled();
        } 
        #endregion

        private void ToggleButtonsEnabled()
        {
            bool status = splitContainerMain.Panel1.Controls.Count != 0;
            toolStripButtonSaveFile.Enabled = status;
            toolStripButtonSettings.Enabled = status;
            toolStripButtonTableDisplay.Enabled = status;
            toolStripButtonGraphToggle.Enabled = status;
        }
    }
}
