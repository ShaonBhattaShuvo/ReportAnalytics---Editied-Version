﻿using System;
using System.Xml;
using System.IO;
using System.ComponentModel;
using DV_ReportAnalytics.Core;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    internal class MainFormPresenter
    {
        private IMainView _mainView;
        private WorkspacePresenterFactory _factory;
        private IViewsProviders _providers;
        private IWorkspacePresenter _currentPresenter; // TODO: replace this with tab views or similar if multipage design needed

        public MainFormPresenter(IMainView view, IViewsProviders providers)
        {
            _mainView = view;
            _mainView.OpenClicked += OnOpenClicked;
            _mainView.ExportClicked += OnExportClicked;
            _mainView.HelpClicked += OnHelpClicked;
            _mainView.SettingsClicked += OnSettingsClicked;
            _mainView.SettingsClicked += OnDisplayClicked;
            _providers = providers;
            _factory = new WorkspacePresenterFactory(providers);
        }

        private void OnOpenClicked(object sender, EventArgs eventArgs)
        {
            var wizard = new WizardPresenter(_factory, _providers.WizardViewsProvider);
            wizard.WizardFinished += OnWizardFinished;
            wizard.PropertyChanged += OnWizardPresenterChanged;
        }

        private void OnExportClicked(object sender, EventArgs eventArgs)
        {

        }

        private void OnHelpClicked(object sender, EventArgs eventArgs)
        {

        }

        private void OnSettingsClicked(object sender, EventArgs eventArgs)
        {

        }

        private void OnDisplayClicked(object sender, EventArgs eventArgs)
        {

        }

        private void OnWizardFinished(object sender, EventArgs eventArgs)
        {
            var wizard = (WizardPresenter)sender;
            _currentPresenter.FilePath = wizard.FilePath;
            _currentPresenter.Initialize();
            _mainView.UpdateWorkspace(_currentPresenter.WorkspaceView);
        }

        private void OnWizardPresenterChanged(object sender, PropertyChangedEventArgs eventArgs)
        {
            _currentPresenter = ((WizardPresenter)sender).SelectedPresenter;
        }

    }
}
