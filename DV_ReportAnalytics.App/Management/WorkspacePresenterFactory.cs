using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    /// <summary>
    /// New workspace presenter should be registred here
    /// </summary>
    public enum ReportTypes : int
    {
        None = 0,
        EPTReport
    }

    internal class WorkspacePresenterFactory
    {
        private IViewsProviders _providers;
        private Dictionary<ReportTypes, Func<IWorkspacePresenter>> _registry;

        #region Registy
        public IWorkspacePresenter this[ReportTypes key]
        {
            get
            {
                if (_registry.TryGetValue(key, out var func))
                    return func();
                else
                    throw new Exception();
            }
        }
        #endregion

        public WorkspacePresenterFactory(IViewsProviders providers)
        {
            _providers = providers;
            _registry = new Dictionary<ReportTypes, Func<IWorkspacePresenter>>
            {
                // register here
                { ReportTypes.EPTReport, () => new EPTPresenter(_providers.EPTViewsProvider) }
            };
        }
    }
}
