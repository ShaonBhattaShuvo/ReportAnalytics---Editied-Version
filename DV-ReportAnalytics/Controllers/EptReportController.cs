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
            // new model
            // model.add()
        }

        public void Export(string path)
        {
            _mainForm.WorkbookView.ActiveWorkbook.SaveAs(path, SpreadsheetGear.FileFormat.OpenXMLWorkbook);
        }

        public void Debug()
        {
            
        }

        // ------ private ------
        private void _OnProcessConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {

        }

        private void _OnDisplayConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {

        }

        private void _OnTableUpdated(object sender, WorkbookTableUpdateEventArgs<TEptData3> e)
        {

        }

        // generate a new model and bind necessary events
        private void _NewModel()
        {
            _model = new EptReportModel(config);
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
