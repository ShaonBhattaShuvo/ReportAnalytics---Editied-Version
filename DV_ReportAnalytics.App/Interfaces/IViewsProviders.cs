namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IViewsProviders
    {
        IWorkspaceViewsProvider this [ReportTypes type] { get; }
        IWizardViewsProvider WizardViewsProvider { get; }
        IMainViewsProvider MainViewsProvider { get; }
    }
}
