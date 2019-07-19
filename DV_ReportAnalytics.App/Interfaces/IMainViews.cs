using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IMainView
    {
        event EventHandler OpenClicked;
        event EventHandler<EventArgs<string>> ExportClicked;
        event EventHandler HelpClicked;
        event EventHandler SettingsClicked;
        event EventHandler DisplayClicked;

        void UpdateWorkspace(object content);
    }

    public interface IMainViewsProvider
    {
        IView CreateSettingsForm();
    }
}
