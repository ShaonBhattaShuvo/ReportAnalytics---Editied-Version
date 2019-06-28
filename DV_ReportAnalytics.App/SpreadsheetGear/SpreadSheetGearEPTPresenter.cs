using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetGear;
using SpreadsheetGear.Windows.Forms;
using DV_ReportAnalytics.App.SpreadsheetGear;

namespace DV_ReportAnalytics.App.SpreadsheetGear
{
    internal class SpreadsheetGearEPTPresenter
    {
        public WorkbookView WorkbookViewModel { get; set; }

        public SpreadsheetGearEPTPresenter(WorkbookView workbookView)
        {
            WorkbookViewModel = workbookView;
        }

        public void Open(string path)
        {
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();

                WorkbookViewModel.ActiveWorkbook.Close();
                WorkbookViewModel.ActiveWorkbook = Factory.GetWorkbook(path);

                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Close()
        {
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();

                WorkbookViewModel.ActiveWorkbook.Close();

                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateSheetWithTables(string sheetName, int maxItemsPerRow, bool heatMap,
            IEnumerable<DV_ReportAnalytics.Core.TableDataCollection<object>> tables)
        {
            try
            {
                WorkbookViewModel.ActiveWorkbookSet.GetLock();

                var ranges = WorkbookViewModel.ActiveWorkbook.InsertTablesInNewSheet(sheetName, maxItemsPerRow, tables);

                if (heatMap)
                    foreach (var range in ranges)
                        range.ApplyHeatMap();

                WorkbookViewModel.ActiveWorkbookSet.ReleaseLock();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
