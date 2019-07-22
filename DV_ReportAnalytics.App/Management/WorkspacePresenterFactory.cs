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
    public class WorkspacePresenterFactory
    {
        private IViewsProviders _providers;
        private ConfigurationManager _configmgr;
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

        public WorkspacePresenterFactory(IViewsProviders providers, ConfigurationManager configmrg)
        {
            _providers = providers;
            _configmgr = configmrg;
            _registry = new Dictionary<ReportTypes, Func<IWorkspacePresenter>>
            {
                // register here
                { ReportTypes.EPTReport,
                    () => new EPTPresenter(_providers[ReportTypes.EPTReport], _configmgr[ReportTypes.EPTReport]) }
            };
        }
    }
}
