using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    interface ISpreadSheetModel
    {
        string FileName {set; get;}
        string Path {set; get;}
        event OpenFileEventHandler OpenFile;
        void setFilePath(string path);
    }
}
