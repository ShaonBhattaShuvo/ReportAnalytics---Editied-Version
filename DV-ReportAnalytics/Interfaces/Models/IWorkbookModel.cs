using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    // T is the table data type of the workbook
    internal interface IWorkbookModel<T>
        where T : ITData
    {
        // send workbook in binary to view to update display
        event WorkbookTableUpdateEventHandler WorkbookTableUpdate;
        string[] TableNames { get; }
        void Add(string name);
        void Remove(string name);
        bool Contains(string name);
        // get all tables
        Dictionary<string, T> GetData();
        Dictionary<string, T> GetData(string[] names);
    }
}
