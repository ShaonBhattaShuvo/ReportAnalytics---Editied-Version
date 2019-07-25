using System;
using System.Configuration;
using System.Collections.Generic;
using DV_ReportAnalytics.App.Interfaces;
using DV_ReportAnalytics.App.Management;
using DV_ReportAnalytics.App.SpreadsheetGear;
using DV_ReportAnalytics.Core;
using DV_ReportAnalytics.Plot;
using SpreadsheetGear.Windows.Forms;

namespace DV_ReportAnalytics.App
{
    internal class EPTPresenter : IWorkspacePresenter
    {
        #region Fields
        private IEPTWorkspaceView _workspaceView;
        private IEPTViewsProvider _viewsProvider;
        private EPTReportModel _model;
        private EPTConfig _config;
        private SpreadsheetGearWorkbookViewController _controller;
        #endregion

        #region IWorkspacePresenter members
        public IView SettingsView
        {
            get
            {
                var view = (IEPTSettingsView)_viewsProvider.CreateSettingsView();
                view.BindData(_config, null);
                view.RequestClosed += OnSettingsViewClosed;
                return view;
            }
        }
        public IView DisplaysView
        {
            get
            {
                var view = (IEPTDisplaysView)_viewsProvider.CreateDisplaysView();
                view.BindData(_config, null);
                view.RequestClosed += OnDisplayViewClosed;
                return view;
            }
        }
        public IView WorkspaceView => _workspaceView;

        public void Export(string path)
        {
            _controller.SaveAs(path);
        }

        public void Initialize(string path)
        {
            FilePath = path;
            _workspaceView = (IEPTWorkspaceView)_viewsProvider.CreateWorkspaceView();
            _controller = new SpreadsheetGearWorkbookViewController((WorkbookView)_workspaceView.WorkbookView);
            ReloadWorkspace();
            InitModel();
            DrawTables(); // remove this if tables are not required to show up after loading
        }

        public void ReloadWorkspace()
        {
            _controller?.Close();
            _controller?.Open(FilePath);
        }

        public void ImportConfig(string path)
        {
            ConfigurationManager.Import(_config, path);
        }
        public void ExportConfig(string path)
        {
            ConfigurationManager.Export(_config, path);
        }
        public void ResetConfig()
        {
            ConfigurationManager.Reset(_config);
        }

        public string FilePath { get; private set; }
        #endregion

        #region Constructor
        public EPTPresenter(IWorkspaceViewsProvider viewsProvider, ApplicationSettingsBase config)
        {
            _viewsProvider = (IEPTViewsProvider)viewsProvider;
            _model = new EPTReportModel();
            _config = (EPTConfig)config;
        }
        #endregion

        private void OnSettingsViewClosed(object sender, EventArgs eventArgs)
        {
            InitModel();
            DrawTables();
        }

        private void OnDisplayViewClosed(object sender, EventArgs eventArgs)
        {
            DrawTables();
        }

        private void InitModel()
        {
            _model.Build(_controller.GetSheetUsedRangeValue(_config.InputSheetName), 
                _config.Parameter,
                _config.Delimiter, 
                Conversions.LetterToNumberColumn(_config.ParameterColumn), 
                Conversions.LetterToNumberColumn(_config.ValueColumn));
        }

        private void DrawTables()
        {
            var tables = _model.GetTableInfoCollection(
                _model.TableNames, 
                _config.RowInterpolation, 
                _config.ColumnInterpolation);

            _controller.UpdateSheetWithTables(
                tables,
                _config.OutputSheetName,
                _config.MaximumItemsPerRow,
                true);

            PlotChart.CreateSurfaceHTML(CONSTANTS.SURFACE_MAP_FILE, tables);
        }
    }
}
