using System;
using System.Windows.Forms;
using DV_ReportAnalytics.Controllers;

namespace DV_ReportAnalytics.Views
{
    /// <summary>
    /// Do not touch this file. All the coding must be done in UIController.cs
    /// </summary>
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // bind controllers and models
            _controller = new MainFormController(this);
            _controller.UserMessageUpdated += _UserMessageUpdated;
        }
              
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Adjust the sizing of the splitter panels
            int panelwidth = (this.Size.Width - splitContainerMain.SplitterWidth) / 2;
            splitContainerMain.SplitterDistance = panelwidth;
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            _controller.AppForm_OpenButtonClicked();
        }

        private void toolStripButtonSaveFile_Click(object sender, EventArgs e)
        {
            _controller.AppForm_SaveButtonClicked();
        }

        private void toolStripButtonTableDisplay_Click(object sender, EventArgs e)
        {
            _controller.AppForm_TableButtonClicked();
        }

        private void toolStripButtonGraphToggle_Click(object sender, EventArgs e)
        {
            // Determine whether to show the graph which depends on the state of the splitter
            splitContainerMain.Panel2Collapsed = !splitContainerMain.Panel2Collapsed;
            _controller.AppForm_GraphButtonClicked();
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            _controller.AppForm_SettingsButtonClicked();
        }

        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            _controller.AppForm_HelpInfoButtonClicked();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
