﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.App;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public partial class WizardView : Form, IWizardView
    {
        public WizardView()
        {
            InitializeComponent();
        }

        #region IWizardView members
        public event EventHandler RequestClosed;
        public event EventHandler<WizardSelectionChangedEventArgs> WizardSelectionChanged;

        public string Path => textBoxFilePath.Text;
        public IWorkspacePresenter SelectedPresenter { get; private set; }

        public void BindData(object source)
        {
            var control = (Control)source;
            control.Dock = DockStyle.Fill;
            panelProperty.Controls.Clear();
            panelProperty.Controls.Add(control);
        } 
        #endregion
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            RequestClosed?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void ListBoxTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportTypes type;
            switch (listBoxTypeList.SelectedIndex)
            {
                case 0:
                    type = ReportTypes.EPTReport;
                    break;
                default:
                    type = ReportTypes.None;
                    break;
            }
            WizardSelectionChanged?.Invoke(this, new WizardSelectionChangedEventArgs(type));
            ValidateFinish();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxFilePath.Text = openFileDialog.FileName;
            ValidateFinish();
        }

        private void ValidateFinish()
        {
            buttonFinish.Enabled = 
                listBoxTypeList.SelectedIndex >= 0 && 
                !string.IsNullOrEmpty(textBoxFilePath.Text);
        }

        private void WizardView_Load(object sender, EventArgs e)
        {
            ValidateFinish();
        }
    }
}
