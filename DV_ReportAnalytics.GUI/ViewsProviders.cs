using System.Collections.Generic;
using DV_ReportAnalytics.App;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class ViewsProviders : IViewsProviders
    {
        private Dictionary<ReportTypes, IWorkspaceViewsProvider> _viewProviders;
        public IWizardViewsProvider WizardViewsProvider { get; }
        public IMainViewsProvider MainViewsProvider { get; }

        public ViewsProviders()
        {
            WizardViewsProvider = new WizardViewProvider();
            MainViewsProvider = new MainViewsProvider();
            // register workspace views here
            _viewProviders = new Dictionary<ReportTypes, IWorkspaceViewsProvider>()
            {
                { ReportTypes.EPTReport, new EPTViewsProvider() }
            };
        }

        public IWorkspaceViewsProvider this[ReportTypes type]
        {
            get
            {
                return _viewProviders[type];
            }
        }
    }
}
