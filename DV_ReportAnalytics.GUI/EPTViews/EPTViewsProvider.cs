using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class EPTViewsProvider : IEPTViewsProvider
    {
        public IEPTSettingsView CreateSettingsView()
        {
            return new EPTSettingsView();
        }

        public IEPTDisplayView CreateDisplayView()
        {
            return null;
        }

        public IEPTWorkspaceView CreateWorkspaceView()
        {
            return new EPTWorkspaceView();
        }
    }
}
