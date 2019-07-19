using System;
using System.Windows.Forms;
using DV_ReportAnalytics.App;
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
            ViewProviders providers = new ViewProviders();
            MainForm mainForm = new MainForm();
            MainFormPresenter mainPresenter = new MainFormPresenter(mainForm, providers);
            Application.Run(mainForm);
            //Application.Run(new Form1());
        }
    }
}
