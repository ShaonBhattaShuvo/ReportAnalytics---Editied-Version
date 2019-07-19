using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class ViewProviders : IViewsProviders
    {
        public IEPTViewsProvider EPTViewsProvider { get; }
        public IWizardViewsProvider WizardViewsProvider { get; }

        public ViewProviders()
        {
            EPTViewsProvider = new EPTViewsProvider();
            WizardViewsProvider = new WizardViewProvider();
        }
    }
}
