using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Models;
using DV_ReportAnalytics.Views;


namespace DV_ReportAnalytics.Controllers
{
    /// <summary>
    /// Place your code here
    /// </summary>
    internal partial class MainFormController: IMainFormController
    {
        public MainFormController(IMainForm mainForm)
        {
            // mainform should be binded with controller here
            _view = mainForm;
            // TODO: Create all necessary classes which require different functionality from MainForm
        }

        // place configuration seletor here
        public void AppForm_OpenButtonClicked(string path)
        {
            _FileOpen(this, new FileOpenEventArgs(path));
        }

        public void AppForm_SaveButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Save File: We can implement functionality in the separate class and create instance of this class in UIController."));
        }

        public void AppForm_TableButtonClicked()
        {
            //_UserMessageUpdated(this, new UserMessageEventArgs("Table Display: We can implement functionality in the separate class and create instance of this class in UIController."));
            EptForm ept = new EptForm();
            ept.Show();
        }

        public void AppForm_GraphButtonClicked()
        {
            if (_model != null)
            {
                
            }
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
    }
}
