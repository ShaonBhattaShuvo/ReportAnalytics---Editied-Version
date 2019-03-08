using System;
using DV_ReportAnalytics.Events;
using System.Xml;

namespace DV_ReportAnalytics.Models
{
    internal interface IWorkbookModel
    {
        string FileName { get; }
        string FilePath { get; }

        // send workbook in binary to view to update display
        event WorkbookUpdateEventHandler WorkbookUpdate;

        // send new workbook path to view to open
        event WorkbookOpenEventHandler WorkbookOpen;

        // update file
        void Update(XmlDocument config);

        // open a new file
        void Open(string path);
    }
}
