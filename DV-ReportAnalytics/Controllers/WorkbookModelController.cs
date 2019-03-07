using System;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Controllers
{
    internal abstract class WorkbookModelController : IWorkbookModelController
    {
        public event WorkbookOpenEventHandler WorkbookOpen;
        private IWorkbookModelView _view;
        private IWorkbookModel _model;

        public virtual void OpenModelView()
        {
            _view.Show();
        }

        // bind to view's event
        protected virtual void _ConfigUpdate(object sender, WorkbookConfigUpdateEventArgs e) { }

        // bind to model's event
        protected virtual void _Update(object sender, WorkbookUpdateEventArgs e) { }

        // raise workbook open event
        protected virtual void _WorkbookOpen()
        {
            if (WorkbookOpen != null)
                WorkbookOpen.Invoke(this, new WorkbookOpenEventArgs(_model.FilePath, true));
        }
    }
}
