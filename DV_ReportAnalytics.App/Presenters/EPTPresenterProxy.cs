using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace DV_ReportAnalytics.App.Presenters
{
    public class EPTPresenterProxy
    {
        public string GetSurfaceHTML(string filePath)
        {
            EPTPresenter presenter = new EPTPresenter();
            presenter.InitModelFromFile(filePath);
            return presenter.GetHtmlTable();
        }
        public string Screenshot(string url)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");//Comment if we want to see the window. 
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            driver.Manage().Window.Size = new System.Drawing.Size(800, 7110);
            driver.Navigate().GoToUrl(url);
            var screenshot = (driver as ITakesScreenshot).GetScreenshot();
            string outputPath = GetPath(url) + "output.png";
            screenshot.SaveAsFile(outputPath);
            driver.Close();
            driver.Quit();
            return outputPath; 
        }
        public string WriteSurfaceHtml(string html, string destinationFileLocation)
        {
            string outputPath = GetPath(destinationFileLocation) + "output.html";
            File.WriteAllText(outputPath, html);
            return outputPath; 
        }
        public string GetPath(string fileLocation) {
            Char charRange = '\\';
            int startIndex = 0;
            int endIndex = fileLocation.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;
            return fileLocation.Substring(startIndex, length);
        }
        public string GetDirectory(string fileLocation) {
            Char charRange = '.';
            int startIndex = 0;
            int endIndex = fileLocation.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;
            return fileLocation.Substring(startIndex, length);
        }
        public void SplitImage(string imageLocation, string directoryLocation) {
            string[] plot_names = new string[] {"Copper_Loss", "Output_Power", "Input_Power", "Rotational_Loss", "Total_Loss","DC_Power",
                "Calculated_System_Efficiency", "Calculated_Motor_Efficiency", "Calculated_Inverter_Efficiency", "Inverter_Loss", "Motor_Loss",
                "System_Loss", "CurrentArms", "CurrentArmsAvr"};
            Bitmap originalImage = new Bitmap(Image.FromFile(imageLocation));
            Rectangle rect;
            Bitmap newPic;
            for (int i = 0, k = 100; i < plot_names.Length; i++, k = k + 500)
            {
                rect = new Rectangle(70, k, originalImage.Width - 180, originalImage.Height / 14);
                newPic = originalImage.Clone(rect, originalImage.PixelFormat);
                string savingLocation = directoryLocation + "/" + plot_names[i] + ".png";
                newPic.Save(savingLocation);
            }
        }
        public void OpenHTML(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
        public string CreateHTMLandPng(string path) {
            string htmlLocation = WriteSurfaceHtml(GetSurfaceHTML(path), path); 
            string imageLocation = Screenshot(htmlLocation);
            //string directoryLocation = GetDirectory(path); //if we want to create directory in the same location of the input file
            string directoryLocation = @"C:\Temp\DV_Imagefiles";
            Directory.CreateDirectory(directoryLocation);
            SplitImage(imageLocation, directoryLocation);
            return directoryLocation;
        }
    }
}
