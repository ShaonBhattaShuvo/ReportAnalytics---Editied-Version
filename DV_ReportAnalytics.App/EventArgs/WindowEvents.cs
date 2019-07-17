using System;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    public class WizardSelectionChangedEventArgs : EventArgs
    {
        public ReportTypes Type { get; }
        public WizardSelectionChangedEventArgs(ReportTypes type) { Type = type; }
        public WizardSelectionChangedEventArgs(int index) { Type = (ReportTypes)index; }
    }

    public class WorkspacePresenterFactoryChangedEventArgs : EventArgs
    {
        public IWorkspacePresenter CurrentPresenter { get; }
        public WorkspacePresenterFactoryChangedEventArgs(IWorkspacePresenter presenter)
        { CurrentPresenter = presenter; }
    }
}
