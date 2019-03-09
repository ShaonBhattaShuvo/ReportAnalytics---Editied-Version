using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    internal interface IMainFormController
    {
        event UserMessageEventHandler UserMessageUpdated;
        void AppForm_OpenButtonClicked(string path);
        void AppForm_SaveButtonClicked();
        void AppForm_TableButtonClicked();
        void AppForm_GraphButtonClicked();
        void AppForm_SettingsButtonClicked();
        void AppForm_HelpInfoButtonClicked();
    }
}
