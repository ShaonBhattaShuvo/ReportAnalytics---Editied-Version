using System;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    internal interface IWorkbookModel
    {
        string FileName { get; }
        string FilePath { get; }

        // send workbook in binary to view to update display
        event WorkbookUpdateEventHandler WorkbookUpdated;

        // send new workbook path to view to open
        event WorkbookUpdateEventHandler WorkbookOpen;

        // update file
        void Update(TEptConfig config);

        // open a new file
        void Open(string path);

        // save to a file
        void Export(string path);
    }
}
