using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetGear;

namespace DV_ReportAnalytics
{
    internal static class SpreadSheetDrawing
    {
        public static TableDataRange InsertTable(this IRange source, TableDataSet<object> data)
        {
            
        }
    }

    internal struct TableDataRange
    {
        public IRange RowHeader { get; }
        public IRange ColumnHeader { get; }
        public IRange DataBody { get; }
        public IRange Table { get; }
        public TableDataRange(IRange table, IRange rowheader, IRange colheader, IRange databody)
        {
            Table = table;
            RowHeader = rowheader;
            ColumnHeader = colheader;
            DataBody = databody;
        }
    }
}
