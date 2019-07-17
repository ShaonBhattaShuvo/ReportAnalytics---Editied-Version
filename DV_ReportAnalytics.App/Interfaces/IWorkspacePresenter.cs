namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IWorkspacePresenter
    {
        IView SettingsView { get; }
        IView DisplayView { get; }
        IView WorkspaceView { get; }
        void Export(string path);
        void Initialize();
        void ReloadWorkspace();
        string FilePath { get; set; }
    }
}
