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
        private Dictionary<ReportTypes, IWorkspacePresenter> _lookup;
        private Dictionary<ReportTypes, Func<IWorkspacePresenter>> _registry;

        #region Registy
        public IWorkspacePresenter this[ReportTypes key]
        {
            get
            {
                if (!_lookup.TryGetValue(key, out IWorkspacePresenter presenter))
                    if (_registry.TryGetValue(key, out Func<IWorkspacePresenter> func))
                        return func();
                    else
                        return null;
                else
                    return presenter;
            }
        }
        #endregion

        public WorkspacePresenterFactory(IViewsProviders providers)
        {
            _providers = providers;
            _lookup = new Dictionary<ReportTypes, IWorkspacePresenter>();
            _registry = new Dictionary<ReportTypes, Func<IWorkspacePresenter>>
            {
                // register here
                { ReportTypes.EPTReport, () => new EPTPresenter(_providers.EPTViewsProvider) }
            };
        }
    }
}
