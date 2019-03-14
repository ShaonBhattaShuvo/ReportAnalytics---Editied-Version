using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
        private IMainForm _mainForm;
        private IWorkbookModelController _workbookModelController;
        public event UserMessageEventHandler UserMessageUpdated = null;
        private ModelTypes _currentModel;

        public MainFormController(IMainForm mainForm)
        {
            // mainform should be binded with controller here
            _mainForm = mainForm;
            _currentModel = ModelTypes.None;
            // TODO: Create all necessary classes which require different functionality from MainForm
        }

        // place configuration seletor here
        public void AppForm_OpenButtonClicked(string path)
        {
            _GetModelControllerType("EptReport");
            _workbookModelController.OpenModel(path);
        }

        public void AppForm_SaveButtonClicked(string path)
        {
            _workbookModelController.Export(path);
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
            //_UserMessageUpdated(this, new UserMessageEventArgs("Implement Show Settings."));
            ConfigForm config = new ConfigForm();
            config.Show();
        }

        public void AppForm_HelpInfoButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Implement Help/Info."));
        }

        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            if (UserMessageUpdated != null)
                UserMessageUpdated.Invoke(sender, args);
        }

        public void Debug()
        {
            ((EptReportController)_workbookModelController).Debug();
        }
    }
}
