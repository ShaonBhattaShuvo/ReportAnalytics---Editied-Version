using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    abstract class ASpreadSheetModel: ISpreadSheetModel
    {
        public string Name {set; get;}
        public string Path {set; get;}
        public event OpenFileEventHandler OpenFile = null;

        public ASpreadSheetModel(string name)
        {
            Name = name;
        }

        public void setFilePath(string path)
        {
            Path = path;
            _OpenFile(); // notify view to open file
        }

        private void _OpenFile()
        {
            // TO-DO
            // read other data from the spreadsheet
            if (OpenFile != null)
            {
                OpenFile.Invoke(this, new OpenFileEventArgs(Path));
            }
        }
    }
}
