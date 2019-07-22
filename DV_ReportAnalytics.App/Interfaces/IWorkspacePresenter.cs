namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IWorkspacePresenter
    {
        IView SettingsView { get; }
        IView DisplaysView { get; }
        IView WorkspaceView { get; }
        void Export(string path);
        void Initialize(string path);
        void ReloadWorkspace();
        void ImportConfig(string path);
        void ExportConfig(string path);
        void ResetConfig();
        string FilePath { get; }
    }
}
