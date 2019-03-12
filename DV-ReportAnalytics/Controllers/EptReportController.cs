using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Controllers
{
    internal sealed class EptReportController : WorkbookModelController, IEptReportController
    {
        private EptReportModel _model;
        private EptForm _view;

        public EptReportController(IMainForm mainForm)
        {
            _mainForm = mainForm;
            _view = null;
            _model = new EptReportModel();
            _Bind();
        }

        public EptReportController() : this(null) { }

        public override void ShowModelView()
        {
            // pass necessary params to view to display
            _view = new EptForm();
            _view.WorkbookConfigUpdate += _OnConfigUpdated;
            _view.Show();
        }

        public override void OpenModel(string path)
        {
            _model.Open(path);
        }

        public override void SetMainView(IMainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public override void Export(string path)
        {
            _model.SaveAs(path);
        }

        protected override void _OnConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {
            _model.Update(e.Config);
        }

        protected override void _OnModelModified(object sender, WorkbookUpdateEventArgs e)
        {
            _mainForm.UpdateWorkbookView(e.Buffer);
        }

        protected override void _OnModelOpen(object sender, WorkbookUpdateEventArgs e)
        {
            _mainForm.OpenWorkbookView(e.Buffer);
        }

        protected override void _Bind()
        {
            _model.WorkbookOpen += _OnModelOpen;
            _model.WorkbookUpdated += _OnModelModified;
        }

    }
}
