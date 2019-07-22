using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class EPTViewsProvider : IEPTViewsProvider
    {
        public IView CreateSettingsView() => new EPTSettingsView();
        public IView CreateDisplaysView() => new EPTDisplaysView();
        public IView CreateWorkspaceView() => new EPTWorkspaceView();
    }
}
