using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace DV_ReportAnalytics.App.Presenters
{
    public class EPTPresenterProxy
    {
        public string GetSurfaceHTML(string filePath)
        {
            // Shaon
            EPTPresenter presenter = new EPTPresenter();
            presenter.InitModelFromFile(filePath);
            return presenter.GetHtmlTable();
        }
        public void SaveExcel(string filePath) {
            EPTPresenter presenter = new EPTPresenter();
            presenter.InitModelFromFile(filePath);
            presenter.DrawTablesCLI(filePath);
            //presenter.Export(filePath);
        }
        public void Screenshot(string url)
        {
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
            string outputPath = url.Substring(startIndex, length) + "output.png";
            screenshot.SaveAsFile(outputPath);
            driver.Close();
            driver.Quit();
        }
        public void WriteSurfaceHtml(string html, string destinationFileLocation)
        {
            Char charRange = '\\';
            int startIndex = destinationFileLocation.IndexOf(charRange);
            int endIndex = destinationFileLocation.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;
            string outputPath = destinationFileLocation.Substring(startIndex, length) + "output.html";
            File.WriteAllText(outputPath, html);
        }
        public void OpenHTML(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
