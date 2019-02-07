using System;
using System.IO;
using DV_ReportAnalytics.Events;

// base model for spreadsheet
// must be inherited before using
// model dostn' care about controllers and views
// it just makes changes and emmit events
namespace DV_ReportAnalytics.Models
{
    public abstract class ASpreadSheetModel: ISpreadSheetModel
    {
        public string FileName {get;}
        public string FilePath {get;}
        public event OpenFileEventHandler OpenFile;

        public ASpreadSheetModel(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
        }

        public void Open()
        {
            // TODO: open spreadsheet, read data, build data structure
            if (OpenFile != null)
            {
                OpenFile.Invoke(this, new OpenFileEventArgs(FilePath));
            }
        }
    }
}
