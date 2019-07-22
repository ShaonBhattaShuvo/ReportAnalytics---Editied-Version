using System;
using System.Configuration;
using DV_ReportAnalytics.App.Interfaces;
using DV_ReportAnalytics.App.SpreadsheetGear;
using DV_ReportAnalytics.Core;
using DV_ReportAnalytics.Plotly;
using SpreadsheetGear.Windows.Forms;

namespace DV_ReportAnalytics.App
{
    internal class EPTPresenter : IWorkspacePresenter
    {
        #region Fields
        private IEPTSettingsView _settingsView;
        private IEPTDisplayView _displayView;
        private IEPTWorkspaceView _workspaceView;
        private IEPTViewsProvider _viewsProvider;
        private EPTReportModel _model;
        private SpreadsheetGearWorkbookViewController _controller;
        private EPTConfig _config;
        #endregion

        #region IWorkspacePresenter members
        public IView SettingsView
        {
            get
            {
                if (_settingsView == null)
                {
                    _settingsView = (IEPTSettingsView)_viewsProvider.CreateSettingsView();
                    _settingsView.BindData(_config);
                    _settingsView.RequestClosed += OnSettingsViewClosed;
                }

                return _settingsView;
            }
        }
        public IView DisplayView
        {
            get
            {
                if (_displayView == null)
                {
                    _displayView = (IEPTDisplayView)_viewsProvider.CreateDisplayView();
                    _displayView.BindData(_config);
                    _displayView.RequestClosed += OnDisplayViewClosed;
                }

                return _displayView;
            }
        }
        public IView WorkspaceView => _workspaceView;

        public void Export(string path)
        {
            _controller.SaveAs(path);
        }

        public void Initialize()
        {
            _workspaceView = (IEPTWorkspaceView)_viewsProvider.CreateWorkspaceView();
            _controller = new SpreadsheetGearWorkbookViewController((WorkbookView)_workspaceView.WorkbookView);
            ReloadWorkspace();
            InitModel();
            DrawTables(_model.TableNames, 0, 0); // remove this if tables are not required to show up after loading
        }

        public void ReloadWorkspace()
        {
            _controller?.Close();
            _controller?.Open(FilePath);
        }

        public string FilePath { get; set; }
        #endregion

        #region Constructor
        public EPTPresenter(IWorkspaceViewsProvider viewsProvider, ApplicationSettingsBase config)
        {
            _viewsProvider = (IEPTViewsProvider)viewsProvider;
            _model = new EPTReportModel();
            _config = (EPTConfig)config;
        } 
        #endregion

        private void OnSettingsViewClosed(object sender, EventArgs e)
        {
            InitModel();
            DrawTables(_model.TableNames, _config.RowInterpolation, _config.ColumnInterpolation); // TODO: pass dynamic variables
        }

        private void OnDisplayViewClosed(object sender, EventArgs e)
        {

        }

        private void InitModel()
        {
            _model.Build(_controller.GetSheetUsedRangeValue(_config.InputSheetName), 
                _config.Parameter,
                _config.Delimiter, 
                Conversions.LetterToNumberColumn(_config.ParameterColumn), 
                Conversions.LetterToNumberColumn(_config.ValueColumn));
        }

        private void DrawTables(string[] items, int rowInterp, int colInterp)
        {
            var tables = _model.GetTableDataCollections(items, rowInterp, colInterp);
            _controller.UpdateSheetWithTables(_config.OutputSheetName,
                _config.MaximumItemsPerRow, 
                true,
                tables);

            // generate 3D efficiency map
            // TODO: This method is not efficient considering tables are already looped in above function
            //       Improvement may be nedded
            string html = string.Empty;
            foreach (var table in tables)
                html += Surface3DEfficiencyMap.Create((string)table.Label, table.DataBody);

            html = "<!DOCTYPE html>" +
               "<html>" +
               "<head>" +
                   "<meta charset = \"UTF-8\" />" +
                    "<script src = \"https://cdn.plot.ly/plotly-latest.min.js\"></script>" +
               "</head>" +
               "<body>" +
               $"  {html}" +
               "</body>" +
               "</html>";

            System.IO.File.WriteAllText("maps.html", html);
        }
    }
}
