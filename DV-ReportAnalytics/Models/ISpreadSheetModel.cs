using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    public interface ISpreadSheetModel
    {
        string FileName {set; get;}
        string FilePath {set; get;}
        event ShowFileEventHandler ShowFile;
        void NotifyOnOpen();
    }
}
