using System;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Controllers
{
    internal abstract class WorkbookModelController : IWorkbookModelController
    {
        protected IWorkbookModelView _workboookModelView;
        protected IWorkbookModel _workbookModel;
        protected IMainForm _mainView; 

        public WorkbookModelController()
        {
            _Bind();
        }

        public virtual void OpenModelView()
        {
            _workboookModelView.Show();
        }

        public virtual void UpdateModel(string path)
        {
            _workbookModel.Open(path);
        }

        public virtual void SetMainView(IMainForm main)
        {
            _mainView = main;
        }

        // bind to view's event
        protected virtual void _ConfigUpdate(object sender, WorkbookConfigUpdateEventArgs e)
        {
            _workbookModel.Update(e.Config);
        }

        // bind to model's event
        protected virtual void _Update(object sender, WorkbookUpdateEventArgs e)
        {
            _mainView.UpdateWorkbookView(e.Buffer);
        }

        // bind to model's event
        protected virtual void _Open(object sender, WorkbookOpenEventArgs e)
        {
            if (e.Done)
                _mainView.OpenWorkbookView(e.Path);
        }

        // bind events
        protected virtual void _Bind()
        {
            _workboookModelView.WorkbookConfigUpdate += _ConfigUpdate;
            _workbookModel.WorkbookOpen += _Open;
            _workbookModel.WorkbookUpdate += _Update;
        }
    }
}
