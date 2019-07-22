using System;
using System.Windows.Forms;
using SpreadsheetGear.Windows.Forms;
using DV_ReportAnalytics.App;
using DV_ReportAnalytics.App.Interfaces;
using CefSharp.WinForms;

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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                ExportClicked?.Invoke(this, new EventArgs<string>(saveFileDialog.FileName));
        }

        private void ToolStripButtonSettings_Click(object sender, EventArgs e)
        {
            SettingsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ToolStripButtonTableDisplay_Click(object sender, EventArgs e)
        {
            DisplayClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ToolStripButtonGraphToggle_Click(object sender, EventArgs e)
        {
            bool collapsed = splitContainerMain.Panel2Collapsed;
            if (collapsed)
                RefreshBrowser("file:///maps.html"); // TODO: remove this hard coding path
            splitContainerMain.Panel2Collapsed = !collapsed;
        }

        private void ToolStripButtonHelp_Click(object sender, EventArgs e)
        {
            HelpClicked.Invoke(this, EventArgs.Empty);
        }

        #region IMainView members
        public event EventHandler OpenClicked;
        public event EventHandler<EventArgs<string>> ExportClicked;
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

        ChromiumWebBrowser _chrome;
        private void RefreshBrowser(string path)
        {
            _chrome.Load(path);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _chrome = new ChromiumWebBrowser("about:blank")
            {
                Dock = DockStyle.Fill
            };
            splitContainerMain.Panel2.Controls.Add(_chrome);
        }
    }
}
