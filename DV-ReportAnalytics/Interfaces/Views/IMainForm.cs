using System;
using System.Windows.Forms;
using SpreadsheetGear.Windows.Forms;

namespace DV_ReportAnalytics.Views
{
    internal interface IMainForm
    {
        // get current workbookview
        WorkbookView WorkbookView { get; }

        // get open file dialog
        OpenFileDialog OpenFileDialog { get; }

        // get save file dialog
        SaveFileDialog SaveFileDialog { get; }
    }
}
