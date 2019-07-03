namespace DV_ReportAnalytics.App.Interfaces
{
    internal interface IWorkspacePresenter<TWorkspaceViewControl, TSettingsViewControl, TDisplayViewControl>
        where TWorkspaceViewControl : IView
        where TSettingsViewControl : IView
        where TDisplayViewControl : IView
    {
        TSettingsViewControl SettingsView { get; }
        TDisplayViewControl DisplayView { get; }
        TWorkspaceViewControl WorkspaceView { get; }
        IWorkspaceViewsProvider<TWorkspaceViewControl, TSettingsViewControl, TDisplayViewControl> ViewsProvider { set; }
        void Export();
    }

    public interface IWorkspaceViewsProvider<TWorkspaceViewControl, TSettingsViewControl, TDisplayViewControl>
    {
        TSettingsViewControl CreateSettingsView();

        TDisplayViewControl CreateDisplayView();

        TWorkspaceViewControl CreateWorkspaceView();
    }
}
