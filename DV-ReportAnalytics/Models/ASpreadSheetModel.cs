using System;
using System.IO;
using DV_ReportAnalytics.Events;

// base model for spreadsheet
// must be inherited before using
// model dostn' care about controllers and views
// it just makes changes and emmit events
namespace DV_ReportAnalytics.Models
{
    abstract class ASpreadSheetModel: ISpreadSheetModel
    {
        public string FileName {get;}
        public string FilePath {get;}
        public event FileOpenEventHandler FileOpen;
        public event DataPlotEventHandler DataPlot;
        private bool _isopen;

        protected ASpreadSheetModel(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
            _isopen = false;
        }

        public void Open()
        {
            _isopen = true;
            // TODO: open spreadsheet, read data, build data structure

            if (FileOpen != null)
            {
                FileOpen.Invoke(this, new FileOpenEventArgs(FilePath)); // update observer
            }
        }

        // this function is used to generate data for plotting
        // TODO: add specific actions in this function
        public virtual void GetPlotData()
        {
            if (_isopen && DataPlot != null)
            {
                string file = @"HTML\index.html";
                string path = Path.GetFullPath(file);
                Console.WriteLine(path);
                DataPlot.Invoke(this, new DataPlotEventArgs(path)); // update observer
            }
        }
    }
}
