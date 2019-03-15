using System;
using System.Xml;
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

        // update display according to settings
        void SetDisplayConfig(XmlDocument config);

        // get current configuration
        string GetDisplayConfig();

        // update process operations
        void SetProcessConfig(XmlDocument config);

        // get current configuration
        string GetProcessConfig();

        // open a new file
        void Open(string path);

        // save to a file
        void Export(string path);
    }
}
