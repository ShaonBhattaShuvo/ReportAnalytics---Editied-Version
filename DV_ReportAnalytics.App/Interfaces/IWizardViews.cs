using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IWizardView : IView
    {
        event EventHandler<WizardSelectionChangedEventArgs> WizardSelectionChanged;
        string Path { get; }
        IWorkspacePresenter SelectedPresenter { get; }
    }

    public interface IWizardViewsProvider
    {
        IWizardView CreateWizardView();
    }
}
