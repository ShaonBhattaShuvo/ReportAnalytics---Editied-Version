﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Controllers;

namespace DV_ReportAnalytics.Views
{
    /// <summary>
    /// Do not touch this file. All the coding must be done in UIController.cs
    /// </summary>
    internal partial class MainForm : Form
    {
        private IMainFormController _controller;

        public MainForm()
        {
            InitializeComponent();

            int panelwidth = (this.Size.Width - splitContainerMain.SplitterWidth) / 2;
            splitContainerMain.SplitterDistance = panelwidth;
            splitContainerMain.Panel2Collapsed = true;
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // inform controller to update model
                _controller.AppForm_OpenButtonClicked(openFileDialog.FileName); 
            }
        }

        private void toolStripButtonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _controller.AppForm_SaveButtonClicked(saveFileDialog.FileName);
            }
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
    }
}
