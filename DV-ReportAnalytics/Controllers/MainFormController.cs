using System;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Constant;


namespace DV_ReportAnalytics.Controllers
{
    /// <summary>
    /// Place your code here
    /// </summary>
    internal partial class MainFormController: IMainFormController
    {
        // ------ public ------
        public MainFormController(IMainForm mainForm)
        {
            // mainform should be binded with controller here
            _mainForm = mainForm;
            _currentModel = ModelTypes.None;
        }

        public void AppForm_OpenButtonClicked()
        {
            OpenFileDialog ofd = _mainForm.OpenFileDialog;
            // open window to select file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // after file being selected open window to ocnfigure process parameter
                AppForm_SettingsButtonClicked();
                _mainForm.EnableTableButtons = OpenWorkbookView(ofd.FileName);
            }
        }

        public void AppForm_SaveButtonClicked()
        {
            SaveFileDialog sfd = _mainForm.SaveFileDialog;
            // open window to select saving location
            if (sfd.ShowDialog() == DialogResult.OK)
                SaveWorkbookView(sfd.FileName);
        }

        public void AppForm_TableButtonClicked()
        {
            _workbookModelController.ShowModelView();
        }

        public void AppForm_GraphButtonClicked()
        {
            
        }

        public void AppForm_SettingsButtonClicked()
        {
            _processConfigForm = new ProcessConfigForm();
            _processConfigForm.WorkbookConfigUpdate += ProcessConfigUpdated;
            _processConfigForm.ShowDialog();
        }

        public void AppForm_HelpInfoButtonClicked()
        {
            UserMessageUpdated(this, new UserMessageEventArgs("Implement Help/Info."));
        }

        // TODO: remove them?
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            if (UserMessageUpdated != null)
                UserMessageUpdated.Invoke(sender, args);
        }
    }
}
