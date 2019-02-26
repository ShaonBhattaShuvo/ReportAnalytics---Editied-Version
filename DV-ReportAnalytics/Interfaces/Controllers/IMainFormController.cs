using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    interface IMainFormController
    {
        event UserMessageEventHandler UserMessageUpdated;
        event FileOpenEventHandler FileOpen;
        void AppForm_OpenButtonClicked(string path);
        void AppForm_SaveButtonClicked();
        void AppForm_TableButtonClicked();
        void AppForm_GraphButtonClicked();
        void AppForm_SettingsButtonClicked();
        void AppForm_HelpInfoButtonClicked();
    }
}
