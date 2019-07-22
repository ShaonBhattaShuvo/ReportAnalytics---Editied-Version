using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetGear;
using SpreadsheetGear.Windows.Forms;
using DV_ReportAnalytics.Core;

namespace DV_ReportAnalytics.App.SpreadsheetGear
{
    public class SpreadsheetGearWorkbookViewController
    {
        public WorkbookView WorkbookViewModel { get; set; }

        public SpreadsheetGearWorkbookViewController(WorkbookView workbookView)
        {
            WorkbookViewModel = workbookView;
        }

        public void Open(string path)
        {
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();
                WorkbookViewModel.ActiveWorkbook = Factory.GetWorkbook(path);
            }
            finally
            {
                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();
            }
        }

        public void Close()
        {
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();
                WorkbookViewModel.ActiveWorkbook.Close();
            }
            finally
            {
                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();
            }
        }

        public void SaveAs(string path)
        {
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();
                WorkbookViewModel.ActiveWorkbook.SaveAs(path, FileFormat.OpenXMLWorkbook);
            }
            finally
            {
                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();
            }
        }

        public void UpdateSheetWithTables(IEnumerable<TableInfo> tables, string sheetName, int maxItemsPerRow, bool heatMap)
        {
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();

                var ranges = WorkbookViewModel.ActiveWorkbook.InsertTablesInNewSheet(sheetName, maxItemsPerRow, tables);

                if (heatMap)
                    ranges.ForEach(x => x.ApplyHeatMap());
            }
            finally
            {
                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();
            }
        }

        public object[,] GetSheetUsedRangeValue(string sheetName)
        {
            object[,] value;
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();
                value = (object[,])WorkbookViewModel.ActiveWorkbook.Worksheets[sheetName].UsedRange.Value;
            }
            finally
            {
                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();
            }
            return value;
        }
    }
}
