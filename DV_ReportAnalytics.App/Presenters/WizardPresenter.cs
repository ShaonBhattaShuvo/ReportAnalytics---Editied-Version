using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    public class WizardPresenter
    {
        private WorkspacePresenterFactory _factory;
        private IWizardView _view;
        private IWizardViewsProvider _provider;
        public event EventHandler WizardFinished;
        public string FilePath { get; private set; }
        public IWorkspacePresenter SelectedPresenter { get; private set; }
        public IWizardView View
        {
            get
            {
                if (_view == null)
                {
                    _view = _provider.CreateWizardView();
                    _view.WizardSelectionChanged += OnSelectionChanged;
                    _view.RequestClosed += OnViewClosed;
                }
                return _view;
            }
        }
        public WizardPresenter(WorkspacePresenterFactory factory, IWizardViewsProvider provier)
        {
            _factory = factory;
            _provider = provier;
        }

        private void OnSelectionChanged(object sender, WizardSelectionChangedEventArgs eventArgs)
        {
            SelectedPresenter = _factory[eventArgs.Type];
            _view.BindData(SelectedPresenter.SettingsView);
        }

        private void OnViewClosed(object sender, EventArgs eventArgs)
        {
            FilePath = _view.Path;
            WizardFinished?.Invoke(this, EventArgs.Empty);
        }
    }
}
