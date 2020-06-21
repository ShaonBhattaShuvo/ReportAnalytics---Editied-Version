using System;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    public class MainFormPresenter
    {
        private IMainView _mainView;
        private WorkspacePresenterFactory _factory;
        private IViewsProviders _providers;
        private IWorkspacePresenter _currentPresenter; // TODO: replace this with tab views or similar if multipage design needed

        public MainFormPresenter(IMainView view, IViewsProviders providers, ConfigurationManager configmgr)
        {
            _mainView = view;
            _mainView.OpenClicked += OnOpenClicked;
            _mainView.ExportClicked += OnExportClicked;
            _mainView.HelpClicked += OnHelpClicked;
            _mainView.SettingsClicked += OnSettingsClicked;
            _mainView.DisplayClicked += OnDisplayClicked;
            _providers = providers;
            _factory = new WorkspacePresenterFactory(providers, configmgr);
        }

        private void OnOpenClicked(object sender, EventArgs eventArgs)
        {
            var wizard = new WizardPresenter(_factory, _providers.WizardViewsProvider);
            wizard.WizardFinished += OnWizardFinished;
            wizard.View.Show();
        }

        private void OnExportClicked(object sender, EventArgs<string> eventArgs)
        {
            _currentPresenter.Export(eventArgs.Value);
        }

        private void OnHelpClicked(object sender, EventArgs eventArgs)
        {
            var about = _providers.MainViewsProvider.CreateAboutForm();
            about.Show();
        }

        private void OnSettingsClicked(object sender, EventArgs eventArgs)
        {
            var dialog = _providers.MainViewsProvider.CreateSettingsForm();
            dialog.BindData(_currentPresenter.SettingsView, null);
            dialog.Show();
        }

        private void OnDisplayClicked(object sender, EventArgs eventArgs)
        {
            var dialog = _providers.MainViewsProvider.CreateSettingsForm();
            dialog.BindData(_currentPresenter.DisplaysView, null);
            dialog.Show();
        }

        private void OnWizardFinished(object sender, EventArgs eventArgs)
        {
            DV_ReportAnalytics.App.Presenters.EPTPresenterProxy proxy = new Presenters.EPTPresenterProxy();
            var wizard = (WizardPresenter)sender;
            proxy.CreateHTMLandPng(wizard.FilePath);
            _currentPresenter = wizard.SelectedPresenter;
            _currentPresenter.Initialize(wizard.FilePath);
            _mainView.UpdateWorkspace(_currentPresenter.WorkspaceView);
        }

        public IMainView View => _mainView;
    }
}
