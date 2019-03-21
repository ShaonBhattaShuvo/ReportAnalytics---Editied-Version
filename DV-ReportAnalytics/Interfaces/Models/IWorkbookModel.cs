using System;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Types;
using SpreadsheetGear;

namespace DV_ReportAnalytics.Models
{
    // T is the table type of the workbook
    internal interface IWorkbookModel<T>
        where T : ITData
    {
        // send workbook in binary to view to update display
        event WorkbookTableUpdateEventHandler<T> WorkbookTableUpdate;

        // udpate display settings when set
        // in xml format
        string DisplayConfig { set; get; }

        // update model when set range
        IRange Range { set; get; }
    }
}
