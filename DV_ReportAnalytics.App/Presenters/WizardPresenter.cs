using System;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    public class WizardPresenter
    {
        private WorkspacePresenterFactory _factory;
        private IWizardViewsProvider _provider;
        public event EventHandler WizardFinished;
        public string FilePath { get; private set; }
        public IWorkspacePresenter SelectedPresenter { get; private set; }
        public IWizardView View
        {
            get
            {
                var view = _provider.CreateWizardView();
                view.WizardSelectionChanged += OnSelectionChanged;
                view.RequestClosed += OnViewClosed;
                view.ConfigExportClicked += OnConfigExportClicked;
                view.ConfigImportClicked += OnConfigImportClicked;
                view.ConfigResetClicked += OnConfigResetClicked;
                return view;
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
            ((IWizardView)sender).BindData(SelectedPresenter.SettingsView, 1);
            ((IWizardView)sender).BindData(SelectedPresenter.DisplaysView, 2);
        }

        private void OnViewClosed(object sender, EventArgs eventArgs)
        {
            FilePath = ((IWizardView)sender).Path;
            WizardFinished?.Invoke(this, EventArgs.Empty);
        }

        private void OnConfigImportClicked(object sender, EventArgs<string> eventArgs)
        {
            SelectedPresenter.ImportConfig(eventArgs.Value);
        }

        private void OnConfigExportClicked(object sender, EventArgs<string> eventArgs)
        {
            SelectedPresenter.ExportConfig(eventArgs.Value);
        }

        private void OnConfigResetClicked(object sender, EventArgs eventArgs)
        {
            SelectedPresenter.ResetConfig();
        }
    }
}
