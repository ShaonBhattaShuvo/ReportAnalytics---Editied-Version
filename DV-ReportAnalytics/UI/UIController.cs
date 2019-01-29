using DV_ReportAnalytics.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DV_ReportAnalytics
{
    /// <summary>
    /// Place your code here
    /// </summary>
    public class UIController
    {
        public event UserMessageEventHandler UserMessageUpdated = null;
       
        public UIController()
        {
            //TODO: Create all necessary classes which require different functionality from MainForm
        }


        public void AppForm_OpenButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Open File: We can implement functionality in the separate class and create instance of this class in UIController."));

        }

        public void AppForm_SaveButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Save File: We can implement functionality in the separate class and create instance of this class in UIController."));
        }

        public void AppForm_TableButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Table Display: We can implement functionality in the separate class and create instance of this class in UIController."));
        }

        public void AppForm_GraphButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Show Graph: We can implement functionality in the separate class and create instance of this class in UIController."));
        }

        public void AppForm_SettingsButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Implement Show Settings."));
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
    }
}
