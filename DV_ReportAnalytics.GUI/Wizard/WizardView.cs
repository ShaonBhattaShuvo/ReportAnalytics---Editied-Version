using System;
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
        public event EventHandler<EventArgs<string>> ConfigImportClicked;
        public event EventHandler<EventArgs<string>> ConfigExportClicked;
        public event EventHandler ConfigResetClicked;

        public string Path => textBoxFilePath.Text;
        public IWorkspacePresenter SelectedPresenter { get; private set; }

        public void BindData(object source, object arguments)
        {
            int args = (int)arguments; // optimize this to avoid unbox
            var control = (Control)source;
            control.Dock = DockStyle.Fill;
            switch (args)
            {
                case 1:
                    panelSettings.Controls.Clear();
                    panelSettings.Controls.Add(control);
                    break;
                case 2:
                    panelDisplays.Controls.Clear();
                    panelDisplays.Controls.Add(control);
                    break;
                default:
                    break;
            }
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
                    return;
            }
            WizardSelectionChanged?.Invoke(this, new WizardSelectionChangedEventArgs(type));
            ToggleButtonstatus();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxFilePath.Text = openFileDialog.FileName;
            ToggleButtonstatus();
        }

        private void ToggleButtonstatus()
        {
            buttonFinish.Enabled = 
                listBoxTypeList.SelectedIndex >= 0 && 
                !string.IsNullOrEmpty(textBoxFilePath.Text);
            linkLabelImport.Enabled = listBoxTypeList.SelectedIndex >= 0;
            linkLabelExport.Enabled = listBoxTypeList.SelectedIndex >= 0;
            linkLabelReset.Enabled = listBoxTypeList.SelectedIndex >= 0;
        }

        private void WizardView_Load(object sender, EventArgs e)
        {
            ToggleButtonstatus();
        }

        private void LinkLabelImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialogConfig.ShowDialog() == DialogResult.OK)
                ConfigImportClicked?.Invoke(this, new EventArgs<string>(openFileDialogConfig.FileName));
        }

        private void LinkLabelExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
                ConfigExportClicked?.Invoke(this, new EventArgs<string>(saveFileDialogConfig.FileName));
        }

        private void LinkLabelReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfigResetClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
