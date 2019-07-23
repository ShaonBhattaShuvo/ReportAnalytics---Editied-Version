using System;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IWizardView : IView
    {
        event EventHandler<EventArgs<ReportTypes>> WizardSelectionChanged;
        event EventHandler<EventArgs<string>> ConfigImportClicked;
        event EventHandler<EventArgs<string>> ConfigExportClicked;
        event EventHandler ConfigResetClicked;
        string Path { get; }
        IWorkspacePresenter SelectedPresenter { get; }
    }

    public interface IWizardViewsProvider
    {
        IWizardView CreateWizardView();
    }
}
