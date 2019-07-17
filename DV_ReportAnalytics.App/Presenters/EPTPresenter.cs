using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.App.Interfaces;
using DV_ReportAnalytics.App.Configurations;
using DV_ReportAnalytics.App.SpreadsheetGear;
using DV_ReportAnalytics.Core;
using DV_ReportAnalytics.Core.Models;

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
                    _settingsView = _viewsProvider.CreateSettingsView();
                    _settingsView.BindData(_config);
                    _settingsView.RequestClosed += 
                        (object sender, EventArgs e) => OnSettingsViewClose((IEPTSettingsView)sender);
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
                    _displayView = _viewsProvider.CreateDisplayView();
                    _displayView.BindData(_config);
                    _displayView.RequestClosed +=
                        (object sender, EventArgs e) => OnDisplayViewClose((IEPTDisplayView)sender);
                }

                return _displayView;
            }
        }
        public IView WorkspaceView
        {
            get
            {
                if (_workspaceView == null)
                {
                    _workspaceView = _viewsProvider.CreateWorkspaceView();
                    _controller = new SpreadsheetGearWorkbookViewController(_workspaceView.WorkbookView);
                }

                return _workspaceView;
            }
        }

        public void Export(string path)
        {
            _controller.SaveAs(path);
        }

        public void Initialize()
        {
            InitModel();
        }
        #endregion

        #region Constructor
        public EPTPresenter(IEPTViewsProvider viewsProvider)
        {
            _viewsProvider = viewsProvider;
            _model = new EPTReportModel();
            _config = EPTConfig.Default;
        } 
        #endregion

        private void OnSettingsViewClose(IEPTSettingsView v)
        {
            //_config.ReportName = v.ReportName;
            //_config.InputSheetName = v.InputSheetName;
            //_config.OutputSheetName = v.OutputSheetName;
            //_config.Parameter = v.Parameter;
            //_config.Delimiter = v.Delimiter;
            //_config.ParameterColumn = v.ParameterColumn;
            //_config.ValueColumn = v.ValueColumn;
            InitModel();
            DrawTables(_model.TableNames, 0, 0); // TODO: pass dynamic variables
        }

        private void OnDisplayViewClose(IEPTDisplayView v)
        {
            //_config.RowInterpolation = v.RowInterpolation;
            //_config.ColumnInterpolation = v.ColumnInterpolation;
            //_config.MaximumItemsPerRow = v.MaximumItemsPerRow;
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
            _controller.UpdateSheetWithTables(_config.OutputSheetName,
                _config.MaximumItemsPerRow, 
                true,
                _model.GetTableDataCollections(items, rowInterp, colInterp));
        }
    }
}
