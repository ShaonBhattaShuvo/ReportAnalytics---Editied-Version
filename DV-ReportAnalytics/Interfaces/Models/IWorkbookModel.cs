using System;
using System.Xml;
using DV_ReportAnalytics.Events;
using SpreadsheetGear;

namespace DV_ReportAnalytics.Models
{
    // T is the table type of the workbook
    internal interface IWorkbookModel<T>
    {
        // send workbook in binary to view to update display
        event WorkbookTableUpdateEventHandler<T> WorkbookTableUpdate;

        // update display according to settings
        void SetDisplayConfig(XmlDocument config);

        // get current configuration
        string GetDisplayConfig();

        // bind range
        void SetRange(IRange range);

        // read data from given range
        void Read();
    }
}
