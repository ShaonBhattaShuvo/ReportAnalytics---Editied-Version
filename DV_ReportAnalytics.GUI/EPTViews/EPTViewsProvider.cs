using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class EPTViewsProvider : IEPTViewsProvider
    {
        public IView CreateSettingsView() => new EPTSettingsView();
        public IView CreateDisplayView() => null;
        public IView CreateWorkspaceView() => new EPTWorkspaceView();
    }
}
