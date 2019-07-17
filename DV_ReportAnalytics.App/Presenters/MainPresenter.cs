using System;
using System.Xml;
using System.IO;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    internal class MainFormPresenter
    {
        private IMainView _mainView;
        private WorkspacePresenterFactory _factory;
        private IWorkspacePresenter _currentPresenter; // TODO: replace this with tab views or similar if multipage design needed

        public MainFormPresenter(IMainView view, IViewsProviders providers)
        {
            _mainView = view;
            _mainView.OpenClicked += (object s, EventArgs e) => OnOpenClicked();
            _mainView.ExportClicked += (object s, EventArgs e) => OnExportClicked();
            _mainView.HelpClicked += (object s, EventArgs e) => OnHelpClicked();
            _mainView.SettingsClicked += (object s, EventArgs e) => OnSettingsClicked();
            _mainView.SettingsClicked += (object s, EventArgs e) => OnDisplayClicked();
            _factory = new WorkspacePresenterFactory(providers);
            _factory.PresenterChanged +=
                (object s, WorkspacePresenterFactoryChangedEventArgs e) => _currentPresenter = e.CurrentPresenter;
        }

        private void OnOpenClicked()
        {

        }

        private void OnExportClicked()
        {

        }

        private void OnHelpClicked()
        {

        }

        private void OnSettingsClicked()
        {

        }

        private void OnDisplayClicked()
        {

        }

    }
}
