using System;
using System.Windows.Forms;
using DV_ReportAnalytics.App;
using DV_ReportAnalytics.App.Interfaces;
using DV_ReportAnalytics.GUI;

namespace DV_ReportAnalytics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // initialize
            MainForm view = new MainForm();
            ViewsProviders providers = new ViewsProviders();
            ConfigurationManager manager = ConfigurationManager.Default;
            ConfigurationManager.ExceptionThrown +=
                (s, e) => ViewsProviders.ShowMessageBox(e.Value);
            MainFormPresenter presenter = new MainFormPresenter(view, providers, manager);

            Application.Run((Form)presenter.View);
        }
    }
}
