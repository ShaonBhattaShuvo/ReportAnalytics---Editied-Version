using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class WizardViewProvider : IWizardViewsProvider
    {
        public IWizardView CreateWizardView()
        {
            return new WizardView();
        }
    }
}
