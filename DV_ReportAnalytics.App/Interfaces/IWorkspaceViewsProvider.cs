namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IWorkspaceViewsProvider
    {
        IView CreateSettingsView();
        IView CreateDisplaysView();
        IView CreateWorkspaceView();
    }
}
