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

        protected SpreadSheetModel(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
        }

        public virtual void Open()
        {
            if (FileOpen != null)
                FileOpen.Invoke(this, new FileOpenEventArgs(FilePath)); // update observer
        }
    }
}
