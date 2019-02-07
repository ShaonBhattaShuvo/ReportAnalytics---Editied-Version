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
    interface IMainFormController
    {
        event UserMessageEventHandler UserMessageUpdated;
        void AppForm_OpenButtonClicked();
        void AppForm_SaveButtonClicked();
        void AppForm_TableButtonClicked();
        void AppForm_GraphButtonClicked();
        void AppForm_SettingsButtonClicked();
        void AppForm_HelpInfoButtonClicked();
    }
}
