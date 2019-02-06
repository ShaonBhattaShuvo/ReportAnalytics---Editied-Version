using DV_ReportAnalytics.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DV_ReportAnalytics
{
    /// <summary>
    /// Do not touch this file. All the coding must be done in UIController.cs
    /// </summary>
    public partial class MainForm : Form
    {
        UIController _uicontroller = null;

        public MainForm()
        {
            InitializeComponent();

            int panelwidth = (this.Size.Width - splitContainerMain.SplitterWidth) / 2;
            splitContainerMain.SplitterDistance = panelwidth;
            splitContainerMain.Panel2Collapsed = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _uicontroller= new UIController();
            _uicontroller.UserMessageUpdated += _UserMessageUpdated;
        }
              
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Adjust the sizing of the splitter panels
            int panelwidth = (this.Size.Width - splitContainerMain.SplitterWidth) / 2;
            splitContainerMain.SplitterDistance = panelwidth;
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            _uicontroller.AppForm_OpenButtonClicked();
        }

        private void toolStripButtonSaveFile_Click(object sender, EventArgs e)
        {
            _uicontroller.AppForm_SaveButtonClicked();
        }

        private void toolStripButtonTableDisplay_Click(object sender, EventArgs e)
        {
            _uicontroller.AppForm_TableButtonClicked();
        }

        private void toolStripButtonGraphToggle_Click(object sender, EventArgs e)
        {
            _uicontroller.AppForm_GraphButtonClicked();

            // Determine whether to show the graph which depends on the state of the splitter
            splitContainerMain.Panel2Collapsed = !splitContainerMain.Panel2Collapsed;
            
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            _uicontroller.AppForm_SettingsButtonClicked();
        }

        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            _uicontroller.AppForm_HelpInfoButtonClicked();
        }


#region "UIController"
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }
#endregion

    }
}
