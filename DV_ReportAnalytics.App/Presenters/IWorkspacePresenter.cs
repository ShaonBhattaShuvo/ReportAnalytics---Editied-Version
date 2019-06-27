namespace DV_ReportAnalytics.App
{
    internal interface IWorkspacePresenter<TWorkspaceViewControl, TSettingsViewControl, TDisplayViewControl>
    {
        TSettingsViewControl SettingsView { get; }
        TDisplayViewControl DisplayView { get; }
        TWorkspaceViewControl WorkspaceView { get; }

        IWorkspaceViewsProvider<TWorkspaceViewControl, TSettingsViewControl, TDisplayViewControl> ViewsProvider { set; }
    }

    public interface IWorkspaceViewsProvider<TWorkspaceViewControl, TSettingsViewControl, TDisplayViewControl>
    {
        TSettingsViewControl CreateSettingsView();

        TDisplayViewControl CreateDisplayView();

        TWorkspaceViewControl CreateWorkspaceView();
    }
}
