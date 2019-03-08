using System;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Controllers
{
    internal abstract class WorkbookModelController : IWorkbookModelController
    {
        protected IWorkbookModelView _view;
        protected IWorkbookModel _model;
        protected IMainForm _main; 

        public virtual void OpenModelView()
        {
            _view.Show();
        }

        public virtual void UpdateModel(string path)
        {
            _model.Open(path);
        }

        public virtual void SetMainView(IMainForm main)
        {
            _main = main;
        }

        // bind to view's event
        protected virtual void _ConfigUpdate(object sender, WorkbookConfigUpdateEventArgs e) { }

        // bind to model's event
        protected virtual void _Update(object sender, WorkbookUpdateEventArgs e) { }

        // bind to model's event
        protected virtual void _Open(object sender, WorkbookOpenEventArgs e) { }
    }
}
