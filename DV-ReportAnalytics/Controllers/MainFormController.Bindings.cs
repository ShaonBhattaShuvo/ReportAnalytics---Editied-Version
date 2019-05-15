using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Constants;
using DV_ReportAnalytics.Events;


namespace DV_ReportAnalytics.Controllers
{
    internal partial class MainFormController
    {
        #region Binding methods
        private void InitializeClass()
        {
            _currentModel = ModelTypes.None;
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
            OpenFileWizardController controller = new OpenFileWizardController(wizard);
            wizard.Show();
        }

        private void MainForm_SaveButtonClicked()
        {

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
