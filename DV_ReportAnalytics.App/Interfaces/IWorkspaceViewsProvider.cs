using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IWorkspaceViewsProvider<TWorkspaceViewControl, TSettingsViewControl, TDisplayViewControl>
        where TWorkspaceViewControl : IView
        where TSettingsViewControl : IView
        where TDisplayViewControl : IView
    {
        TSettingsViewControl CreateSettingsView();

        TDisplayViewControl CreateDisplayView();

        TWorkspaceViewControl CreateWorkspaceView();
    }
}
