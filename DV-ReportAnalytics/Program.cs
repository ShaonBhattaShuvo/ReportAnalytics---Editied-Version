using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.UI;

namespace DV_ReportAnalytics
{
    static class Program
    {
        static MainForm _appform = null;
        public static MainForm AppForm
        {
            get { return _appform; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _appform = new MainForm();
            Application.Run(AppForm);
        }
    }
}
