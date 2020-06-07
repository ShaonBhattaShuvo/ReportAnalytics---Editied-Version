using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DV_ReportAnalytics.App;
using DV_ReportAnalytics.App.Presenters;
using DV_ReportAnalytics.GUI;
namespace DV_ReportAnalytics
{
    static class Program
    {   
        // defines for commandline output
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // redirect console output to parent process;
            // must be before any calls to Console.WriteLine()
            AttachConsole(ATTACH_PARENT_PROCESS);
            EPTPresenterProxy proxy = new EPTPresenterProxy();
            if (args.Length == 1) 
            {
                //Sending the enter key is not really needed, but otherwise the user thinks the app is still running by looking at the commandline. 
                //The enter key takes care of displaying the prompt again.
                //SpreadsheetGearWorkbookViewController svc = new SpreadsheetGearWorkbookViewController();
                string htmlLocation = proxy.WriteSurfaceHtml(proxy.GetSurfaceHTML(args[0]), args[0]);
                //Opening the html file in default browser
                //proxy.OpenHTML(htmlLocation);
                //Capturing Screenshop as png format. 
                string imageLocation = proxy.Screenshot(htmlLocation);
                string directoryLocation = proxy.GetDirectory(args[0]);
                Directory.CreateDirectory(directoryLocation);
                proxy.SplitImage(imageLocation,directoryLocation);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                Application.Exit();
                // pass input/output path as argument e.g. "C:\Users\Downloads\test-Copy.xlsx"
            }
            else if (args.Length == 2)
            {
                //Sending the enter key is not really needed, but otherwise the user thinks the app is still running by looking at the commandline. 
                //The enter key takes care of displaying the prompt again.
                //SpreadsheetGearWorkbookViewController svc = new SpreadsheetGearWorkbookViewController();
                string htmlLocation= proxy.WriteSurfaceHtml(proxy.GetSurfaceHTML(args[0]), args[1]);
                //Opening the html file in default browser
                //proxy.OpenHTML(args[1]);
                //Capturing Screenshop as png format. 
                string imageLocation = proxy.Screenshot(htmlLocation);
                string directoryLocation = proxy.GetDirectory(args[1]);
                Directory.CreateDirectory(directoryLocation);
                proxy.SplitImage(imageLocation, directoryLocation);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                Application.Exit();
                //pass input/output path as argument e.g. "C:\Users\Downloads\test-Copy.xlsx" "C:\Users\Downloads\test-Copy.Result.html"
            }
            else
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
}
