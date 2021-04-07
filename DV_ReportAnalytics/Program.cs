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
            //AttachConsole(ATTACH_PARENT_PROCESS);
            EPTPresenterProxy proxy = new EPTPresenterProxy();
            if (args.Length == 2)
            {
                if (args[1].Equals("EPTReport") || args[1].Equals("EPT Report"))
                {
                    //Sending the enter key is not really needed, but otherwise the user thinks the app is still running by looking at the commandline. 
                    //The enter key takes care of displaying the prompt again.
                    //SpreadsheetGearWorkbookViewController svc = new SpreadsheetGearWorkbookViewController();
                    string contourHtmlLocation = proxy.WriteContourHtml(proxy.GetContourHTML(args[0]), args[0]);
                    string surfaceHtmlLocation = proxy.WriteSurfaceHtml(proxy.GetSurfaceHTML(args[0]), args[0]);
                    //Opening the html file in default browser
                    //proxy.OpenHTML(htmlLocation);
                    //Capturing Screenshop as png format. 
                    string imageLocation = proxy.Screenshot(contourHtmlLocation, "Contour.png");
                    //string directoryLocation = proxy.GetDirectory(args[0]); //if we want to create directory according to same name as input file
                    string directoryLocation = proxy.GetPath(args[0]) + "/ContourImages";
                    Directory.CreateDirectory(directoryLocation);
                    proxy.SplitImage(imageLocation, directoryLocation);
                    imageLocation = proxy.Screenshot(surfaceHtmlLocation, "Surface3D.png");
                    directoryLocation = proxy.GetPath(args[0]) + "/Surface3DImages";
                    Directory.CreateDirectory(directoryLocation);
                    proxy.SplitImage(imageLocation, directoryLocation);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    Application.Exit();
                }
                else
                {
                    Console.WriteLine("Please Enter the report name correctly! (e.g. EPTReport)");
                }

                // pass input/output path as argument e.g. "C:\Users\Downloads\test-Copy.xlsx" "EPTReport""
            }
            else if (args.Length == 3)
            {
                if (args[2].Equals("EPTReport") || args[2].Equals("EPT Report"))
                {
                    //Sending the enter key is not really needed, but otherwise the user thinks the app is still running by looking at the commandline. 
                    //The enter key takes care of displaying the prompt again.
                    //SpreadsheetGearWorkbookViewController svc = new SpreadsheetGearWorkbookViewController();
                    string contourHtmlLocation = proxy.WriteContourHtml(proxy.GetContourHTML(args[0]), args[1]);
                    string surfaceHtmlLocation = proxy.WriteSurfaceHtml(proxy.GetSurfaceHTML(args[0]), args[1]);
                    //Opening the html file in default browser
                    //proxy.OpenHTML(args[1]);
                    //Capturing Screenshop as png format. 
                    string imageLocation = proxy.Screenshot(contourHtmlLocation, "Contour.png");
                    //string directoryLocation = proxy.GetDirectory(args[0]); //if we want to create directory according to same name as input file
                    string directoryLocation = proxy.GetPath(args[1]) + "/ContourImages";
                    Directory.CreateDirectory(directoryLocation);
                    proxy.SplitImage(imageLocation, directoryLocation);
                    imageLocation = proxy.Screenshot(surfaceHtmlLocation, "Surface3D.png");
                    directoryLocation = proxy.GetPath(args[1]) + "/Surface3DImages";
                    Directory.CreateDirectory(directoryLocation);
                    proxy.SplitImage(imageLocation, directoryLocation);
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    Application.Exit();
                    //pass input/output path as argument e.g. "C:\Users\Downloads\test-Copy.xlsx" "C:\Users\Downloads\" "EPTReport"  
                }
                else
                {
                    Console.WriteLine("Please Enter the report name correctly! (e.g. EPTReport)");
                }
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
