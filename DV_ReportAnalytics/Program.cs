using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DV_ReportAnalytics.App;
using DV_ReportAnalytics.App.Presenters;
using DV_ReportAnalytics.App.SpreadsheetGear;
using DV_ReportAnalytics.GUI;

namespace DV_ReportAnalytics
{
    static class Program
    {   
        // Shaon 
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
            //Shaon
            // redirect console output to parent process;
            // must be before any calls to Console.WriteLine()
            AttachConsole(ATTACH_PARENT_PROCESS);

            if (args.Length == 2)
            {   //Shaon
                // sending the enter key is not really needed, but otherwise the user thinks the app is still running by looking at the commandline. The enter key takes care of displaying the prompt again.
                EPTPresenterProxy proxy = new EPTPresenterProxy();
                //SpreadsheetGearWorkbookViewController svc = new SpreadsheetGearWorkbookViewController();
                WriteSurfaceHtml(proxy.GetSurfaceHTML(args[0]), args[1]);
                WriteAsPdf(args[1]);
                //svc.SaveAs(args[0]);
                System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                Application.Exit();
                // "C:\Users\Downloads\test-Copy.xlsx" "C:\Users\Downloads\test-Copy.Result.html"
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
        //Shaon
        private static void WriteSurfaceHtml(string html, string destinationFileName)
        {
            File.WriteAllText(destinationFileName, html);
            
        }
        private static void WriteAsPdf(string destinationFileName) {
            //Render any HTML fragment or document to HTML
             var Renderer = new IronPdf.HtmlToPdf();
            //string to pdf
            //var PDF = Renderer.RenderHtmlAsPdf(html);
            //var PDF = Renderer.RenderHTMLFileAsPdf("C:/Users/User/Desktop/Output.html");
            var PDF = Renderer.RenderHTMLFileAsPdf(destinationFileName);
            //writing the output path
            //var OutputPath = "C:/Users/User/Desktop/HtmlToPDF.pdf";
            Char charRange = '\\';
            int startIndex = destinationFileName.IndexOf(charRange);
            int endIndex = destinationFileName.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;
            string outputPath = destinationFileName.Substring(startIndex, length) + "HtmlToPdf.pdf";
            PDF.SaveAs(outputPath);
        }
        //Shaon
        private static void JavaStriptFileValue(string stringJS, string destinationFileName)
        {
            Char charRange = '\\';
            int startIndex = destinationFileName.IndexOf(charRange);
            int endIndex = destinationFileName.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;
            string newJSFileLocation = destinationFileName.Substring(startIndex, length) + "plotly-latest.min.js";
            File.WriteAllText(newJSFileLocation, stringJS);
        }
    }
}
