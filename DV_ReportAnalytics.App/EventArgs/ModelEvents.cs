using System;
using SpreadsheetGear;

namespace DV_ReportAnalytics
{
    internal class WorkbookUpdateEventArgs : EventArgs
    {
        public IWorkbook Workbook { get; } = null;
        public string Message { get; } = null;
        public WorkbookUpdateEventArgs() { }
        public WorkbookUpdateEventArgs(IWorkbook workbook) { Workbook = workbook; }
        public WorkbookUpdateEventArgs(string message) { Message = message; }
        public WorkbookUpdateEventArgs(IWorkbook workbook, string message) { Workbook = workbook; Message = message; }
    }
}
