using System;
using System.IO;
using DV_ReportAnalytics.Events;

// base model for spreadsheet
// must be inherited before using
// model dostn' care about controllers and views
// it just makes changes and emmit events
namespace DV_ReportAnalytics.Models
{
    abstract class SpreadSheetModel: ISpreadSheetModel
    {
        public string FileName {get;}
        public string FilePath {get;}
        public event FileOpenEventHandler FileOpen;
        private bool _isOpen;

        protected SpreadSheetModel(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
            _isOpen = false;
        }

        public void Open()
        {
            _isOpen = true;
            // TODO: open spreadsheet, read data, build data structure

            if (FileOpen != null)
            {
                FileOpen.Invoke(this, new FileOpenEventArgs(FilePath)); // update observer
            }
        }
    }
}
