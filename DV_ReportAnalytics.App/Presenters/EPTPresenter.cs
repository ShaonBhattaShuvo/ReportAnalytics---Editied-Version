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
        #endregion

        #region IWorkspacePresenter members
        public IView SettingsView
        {
            get
            {
                if (_settingsView == null)
                {
                    _settingsView = _viewsProvider.CreateSettingsView();
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
        } 
        #endregion

        private void OnSettingsViewClose(IEPTSettingsView v)
        {
            var c = EPTConfig.Default;
            c.ReportName = v.ReportName;
            c.InputSheetName = v.InputSheetName;
            c.OutputSheetName = v.OutputSheetName;
            c.Parameter = v.Parameter;
            c.Delimiter = v.Delimiter;
            c.ParameterColumn = v.ParameterColumn;
            c.ValueColumn = v.ValueColumn;
            InitModel();
            DrawTables(_model.TableNames, 0, 0); // TODO: pass dynamic variables
        }

        private void OnDisplayViewClose(IEPTDisplayView v)
        {
            var c = EPTConfig.Default;
            c.RowInterp = v.RowInterpolation;
            c.ColumnInterp = v.ColumnInterpolation;
            c.MaxItemsPerRow = v.MaximumItemsPerRow;
        }

        private void InitModel()
        {
            var c = EPTConfig.Default;
            _model.Build(_controller.GetSheetUsedRangeValue(c.InputSheetName), c.Parameter, c.Delimiter, 
                Conversions.LetterToNumberColumn(c.ParameterColumn), Conversions.LetterToNumberColumn(c.ValueColumn));
        }

        private void DrawTables(string[] items, int rowInterp, int colInterp)
        {
            var c = EPTConfig.Default;
            _controller.UpdateSheetWithTables(c.OutputSheetName, c.MaxItemsPerRow, true,
                _model.GetTableDataCollections(items, rowInterp, colInterp));
        }
    }
}
