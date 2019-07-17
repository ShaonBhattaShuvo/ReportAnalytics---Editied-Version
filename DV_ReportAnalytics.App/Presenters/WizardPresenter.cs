using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    internal class WizardPresenter
    {
        WorkspacePresenterFactory _factory;
        IWizardView _view;
        public WizardPresenter(WorkspacePresenterFactory factory, IWizardViewsProvider provier)
        {
            _factory = factory;
            _view = provier.CreateWizardView();
            _view.WizardSelectionChanged += 
                (object s, WizardSelectionChangedEventArgs e) => _view.BindData(_factory[e.Type].SettingsView);
        }
    }
}
