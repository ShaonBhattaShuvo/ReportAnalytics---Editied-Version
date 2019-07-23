using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class MainViewsProvider : IMainViewsProvider
    {
        public IView CreateSettingsForm()
        {
            return new SettingsForm();
        }

        public IView CreateAboutForm()
        {
            return new AboutForm();
        }
    }
}
