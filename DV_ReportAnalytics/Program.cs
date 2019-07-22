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
            MainFormPresenter mainPresenter = new MainFormPresenter(
                new MainForm(),
                new ViewsProviders(),
                new ConfigurationManager());
            Application.Run((Form)mainPresenter.View);
        }
    }
}
