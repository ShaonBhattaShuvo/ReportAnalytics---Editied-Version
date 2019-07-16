using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    internal interface IWorkspacePresenter
    {
        IView SettingsView { get; }
        IView DisplayView { get; }
        IView WorkspaceView { get; }
        void Export();
    }
}
