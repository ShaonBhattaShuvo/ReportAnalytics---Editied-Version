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
    internal sealed class EptReportController : IEptReportController
    {
        private EptReportModel _model;
        private EptConfigForm _view;
        private IMainForm _mainForm;
        private Regex _filter;
        private XmlDocument _processConfig;
        private XmlDocument _displayConfig;
        private string[] _tableName;

        // ------ properties ------

        // ------ public ------
        public EptReportController(IMainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void ShowModelView()
        {
            _NewView();
            _view.Show();
        }

        public void RefreshModel()
        {
            WorkbookView wbv = _mainForm.WorkbookView;
            IRange range = wbv.ActiveWorkbook.Worksheets[_processConfig.GetValue("InputSheetName")].UsedRange; // replace name with the name in config
            int nameIndex = _processConfig.GetValue<int>("SearchIndexName");
            int valueIndex = _processConfig.GetValue<int>("SearchIndexValue");

            if (range != null)
            {
                // search row by row
                for (int i = 0; i < range.ColumnCount; i++)
                {
                    string name = (string)range.Cells[i, nameIndex].Value;
                    MatchCollection matches = _filter.Matches(name);
                    // if there is any match
                    if (matches.Count > 0)
                    {
                        // 0 is the table name, 1 is the row, 0is the column
                        string tableName = matches[0].Value;
                        double row = Convert.ToDouble(matches[1].Value);
                        double column = Convert.ToDouble(matches[2].Value);
                        // initiate non-existed table
                        if (!_model.Contains(tableName))
                        {
                            _model.Add(tableName);

                        }
                        // set value
                        _model[tableName][row, column] = (double)range.Cells[i, valueIndex].Value;
                    }
                }
            }
        }

        public void Export(string path)
        {
            _mainForm.WorkbookView.ActiveWorkbook.SaveAs(path, SpreadsheetGear.FileFormat.OpenXMLWorkbook);
        }

        // ------ private ------
        private void _OnProcessConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {
            _processConfig = e.Config;
            // TODO: refresh tables
        }

        private void _OnDisplayConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {
            _displayConfig = e.Config;
            // TODO: get tables accroding to config
        }

        private void _OnTableUpdated(object sender, WorkbookTableUpdateEventArgs e)
        {
            _tableName = e.TableNames;
        }

        // generate a new model and bind necessary events
        private void _NewModel()
        {
            _model = new EptReportModel();
            _model.WorkbookTableUpdate += _OnTableUpdated;
        }

        // generate a new view and bind necessary events
        private void _NewView()
        {
            _view = new EptConfigForm();
            _view.WorkbookConfigUpdate += _OnDisplayConfigUpdated;
        }
    }
}
