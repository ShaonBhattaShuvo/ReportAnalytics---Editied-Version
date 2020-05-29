using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DV_ReportAnalytics.App;
using DV_ReportAnalytics.App.Presenters;
using DV_ReportAnalytics.GUI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

            if (args.Length == 2)
            {   
                // sending the enter key is not really needed, but otherwise the user thinks the app is still running by looking at the commandline. The enter key takes care of displaying the prompt again.
                EPTPresenterProxy proxy = new EPTPresenterProxy();
                //SpreadsheetGearWorkbookViewController svc = new SpreadsheetGearWorkbookViewController();
                WriteSurfaceHtml(proxy.GetSurfaceHTML(args[0]), args[1]);
                //Opening the html file in default browser
                OpenHTML(args[1]);
                //Capturing Screenshop as png format. 
                Screenshot(args[1]);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                Application.Exit();
                // pass input/output path as arguent e.g. "C:\Users\Downloads\test-Copy.xlsx" "C:\Users\Downloads\test-Copy.Result.html"
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
        
        private static void WriteSurfaceHtml(string html, string destinationFileName)
        {
            File.WriteAllText(destinationFileName, html);
        }
        private static void OpenHTML(string url) {
            System.Diagnostics.Process.Start(url);
        }
        private static void Screenshot(string url) {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");//Comment if we want to see the window. 
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            driver.Manage().Window.Size = new System.Drawing.Size(800, 7100);
            driver.Navigate().GoToUrl(url);
            var screenshot = (driver as ITakesScreenshot).GetScreenshot();
            Char charRange = '\\';
            int startIndex = url.IndexOf(charRange);
            int endIndex = url.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;
            string outputPath = url.Substring(startIndex, length) + "screenshot.png";
            screenshot.SaveAsFile(outputPath);
            driver.Close();
            driver.Quit();
        }
    }
}
