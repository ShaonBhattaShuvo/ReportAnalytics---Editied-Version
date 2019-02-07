using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

// base model for spreadsheet
// must be inherited before using
namespace DV_ReportAnalytics.Models
{
    public abstract class ASpreadSheetModel: ISpreadSheetModel
    {
        public string FileName {set; get;}
        public string FilePath {set; get;}
        public event ShowFileEventHandler ShowFile;

        public ASpreadSheetModel(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
        }

        public void NotifyOnOpen()
        {
            if (ShowFile != null)
            {
                ShowFile.Invoke(this, new ShowFileEventArgs(FilePath));
            }
        }
    }
}
