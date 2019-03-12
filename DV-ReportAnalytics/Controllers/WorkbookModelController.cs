using System;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    internal abstract class WorkbookModelController : IWorkbookModelController
    {
        protected IMainForm _mainForm;

        public abstract void ShowModelView();

        public abstract void OpenModel(string path);

        public abstract void SetMainView(IMainForm mainForm);

        public abstract void Export(string path);

        // bind to view's event
        protected abstract void _OnConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e);

        // bind to model's event
        protected abstract void _OnModelModified(object sender, WorkbookUpdateEventArgs e);

        // bind to model's event
        protected abstract void _OnModelOpen(object sender, WorkbookUpdateEventArgs e);

        // bind events
        protected abstract void _Bind();
    }
}
