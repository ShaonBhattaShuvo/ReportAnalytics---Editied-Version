using System;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Controllers
{
    internal abstract class WorkbookModelController<TModel, TModelView, TMainForm> : IWorkbookModelController<TMainForm>
        where TModel : IWorkbookModel, new()
        where TModelView : IWorkbookModelView, new()
        where TMainForm : IMainForm
    {
        protected TModel _workbookModel;
        protected TModelView _workboookModelView;
        protected TMainForm _mainForm; 

        public WorkbookModelController()
        {
            _workbookModel = new TModel();
            _workboookModelView = new TModelView();
            _Bind();
        }

        public virtual void ShowModelView()
        {
            _workboookModelView.Show();
        }

        public virtual void OpenModel(string path)
        {
            _workbookModel.Open(path);
        }

        public virtual void SetMainView(TMainForm mainForm)
        {
            _mainForm = mainForm;
        }

        // bind to view's event
        protected virtual void _ConfigUpdate(object sender, WorkbookConfigUpdateEventArgs e)
        {
            _workbookModel.Update(e.Config);
        }

        // bind to model's event
        protected virtual void _Update(object sender, WorkbookUpdateEventArgs e)
        {
            _mainForm.UpdateWorkbookView(e.Buffer);
        }

        // bind to model's event
        protected virtual void _Open(object sender, WorkbookOpenEventArgs e)
        {
            if (e.Done)
                _mainForm.OpenWorkbookView(e.Path);
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
