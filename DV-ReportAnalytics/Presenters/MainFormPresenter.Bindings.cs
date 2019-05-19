using System;

namespace DV_ReportAnalytics.UI
{
    internal partial class MainFormPresenter
    {
        #region Binding methods
        private void InitializeClass()
        {
            /* binding UI actions */
            _mainForm.ButtonOpenFile.Click += (object sender, EventArgs e) => MainForm_OpenButtonClicked();
            _mainForm.ButtonSaveFile.Click += (object sender, EventArgs e) => MainForm_SaveButtonClicked();
            _mainForm.ButtonSettings.Click += (object sender, EventArgs e) => MainForm_SettingsButtonClicked();
            _mainForm.ButtonTableDisplay.Click += (object sender, EventArgs e) => MainForm_TableButtonClicked();
            _mainForm.ButtonGraphToggle.Click += (object sender, EventArgs e) => MainForm_GraphButtonClicked();
            _mainForm.ButtonHelp.Click += (object sender, EventArgs e) => MainForm_HelpButtonClicked();
            _mainForm.Resize += (object sender, EventArgs e) => MainForm_Resize();
        }

        private void MainForm_OpenButtonClicked()
        {
            OpenFileWizard wizard = new OpenFileWizard();
            wizard.ContentUpdated += UpdateSettings;
            OpenFileWizardPresenter presenter = new OpenFileWizardPresenter(wizard);
            wizard.Show();
            _mainForm.ButtonSaveFile.Enabled = true;
        }

        private EPTModel model;
        private void MainForm_SaveButtonClicked()
        {
            model.Build(_doc.GetNodeValue("Paths/Result"), _doc);
            model.Draw(_doc.GetNodeValue("Paths/Result"));
        }

        private void MainForm_TableButtonClicked()
        {

        }

        private void MainForm_GraphButtonClicked()
        {

        }

        private void MainForm_SettingsButtonClicked()
        {

        }

        private void MainForm_HelpButtonClicked()
        {

        }

        private void MainForm_Resize()
        {

        }

        private void UpdateSettings(object sender, ContentUpdateEventArgs e)
        {
            if (_doc == null || !_doc.DocumentElement.OuterXml.Equals(e.Content.DocumentElement.OuterXml))
            {
                _doc = e.Content;
                InitializeModel();
            }
        }
        #endregion
    }
}
