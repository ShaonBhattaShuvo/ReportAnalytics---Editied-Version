using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.RegularExpressions;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Models;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Extensions;
using SpreadsheetGear;
using SpreadsheetGear.Windows.Forms;

namespace DV_ReportAnalytics.Controllers
{
    internal sealed class EptReportController
    {
        private IEptReportModel _model;
        //private IEptConfigForm _view;
        //private IMainForm _mainForm;
        private XmlDocument _processConfig;
        private XmlDocument _displayConfig;

        // ------ properties ------

        // ------ public ------
        public EptReportController()
        {
            //_mainForm = mainForm;
            NewModel();
        }

        public void ShowModelView()
        {
            NewView();
            //_view.ShowDialog();
        }

        //public void SetProcessConfig(XmlDocument config)
        //{
        //    _processConfig = config;
        //    RefreshModel();
        //}

        // ------ private ------
        private void OnDisplayConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {
            _displayConfig = e.Config;
            // TODO: update workbookview
        }

        private void OnTableUpdated(object sender, WorkbookTableUpdateEventArgs e)
        {

        }

        // generate a new model and bind necessary events
        private void NewModel()
        {
            _model = new EptReportModel();
            _model.WorkbookTableUpdate += OnTableUpdated;
        }

        // generate a new view and bind necessary events
        private void NewView()
        {
            //_view = new EptConfigForm(_displayConfig);
            //_view.WorkbookConfigUpdate += OnDisplayConfigUpdated;
        }

        //private void RefreshModel()
        //{
        //    Regex filter = new Regex("");
        //    //WorkbookView wbv = _mainForm.WorkbookView;
        //    //IRange range = wbv.ActiveWorkbook.Worksheets[_processConfig.GetNodeValue("InputSheetName")].UsedRange; // replace name with the name in config
        //    int nameIndex = _processConfig.GetNodeValue<int>("SearchIndexName");
        //    int valueIndex = _processConfig.GetNodeValue<int>("SearchIndexValue");

        //    if (range != null)
        //    {
        //        // search row by row
        //        for (int i = 0; i < range.ColumnCount; i++)
        //        {
        //            string name = (string)range.Cells[i, nameIndex].Value;
        //            MatchCollection matches = filter.Matches(name);
        //            // if there is any match
        //            if (matches.Count > 0)
        //            {
        //                // 0 is the table name, 1 is the row, 0is the column
        //                string tableName = matches[0].Value;
        //                double row = Convert.ToDouble(matches[1].Value);
        //                double column = Convert.ToDouble(matches[2].Value);
        //                // initiate non-existed table
        //                if (!_model.Contains(tableName))
        //                {
        //                    _model.Add(tableName);

        //                }
        //                // set value
        //                _model[tableName][row, column] = (double)range.Cells[i, valueIndex].Value;
        //            }
        //        }
        //    }
        //}
    }
}
