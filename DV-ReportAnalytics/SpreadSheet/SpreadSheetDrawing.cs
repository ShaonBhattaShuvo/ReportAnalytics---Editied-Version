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
        public static TableDataRange InsertTable<T>(this IRange source, TableDataSet<T> data)
        {
            IRange topLeft = source.Worksheet.Cells[0, 0];
            // insert title
            IRange labelRange = source.Cells[0, 0];
            labelRange.Value = data.Label;
            // insert column label
            IRange columnLabelRange = source.Cells[0, 1];
            columnLabelRange.Value = data.ColumnLabel;
            // insert row label
            IRange rowLabelRange = source.Cells[1, 0];
            rowLabelRange.Value = data.RowLabel;
            // insert column header
            IRange columnHeaderRange = source.Cells[1, 1, 1, data.ColumnHeader.Length - 1 + 1];
            columnHeaderRange.Value = data.ColumnHeader.ToTableRowArray();
            // insert row header
            IRange rowHeaderRange = source.Cells[2, 0, data.RowHeader.Length - 1 + 2, 0];
            rowHeaderRange.Value = data.RowHeader.ToTableColumnArray();
            // insert data body
            IRange dataBodyRange = source.Cells[2, 1,
                data.DataBody.GetLength(0) - 1 + 2,
                data.DataBody.GetLength(1) - 1 + 1];
            dataBodyRange.Value = data.DataBody.ToTableDataArray();
            // table range
            IRange all = source.Cells[0, 0,
                rowLabelRange.RowCount + rowHeaderRange.RowCount,
                columnHeaderRange.ColumnCount];
            return new TableDataRange()
            {
                Label = labelRange,
                RowLabel = rowLabelRange,
                ColumnLabel = columnLabelRange,
                RowHeader = rowHeaderRange,
                ColumnHeader = columnHeaderRange,
                DataBody = dataBodyRange,
                All = all
            };
        }

        public static object[,] ToTableColumnArray<T>(this T[] source)
        {
            object[,] result = new object[source.Length, 1];
            for (int i = 0; i < source.Length; i++)
                result[i, 0] = source[i];
            return result;
        }

        public static object[,] ToTableRowArray<T>(this T[] source)
        {
            object[,] result = new object[1, source.Length];
            for (int i = 0; i < source.Length; i++)
                result[0, i] = source[i];
            return result;
        }

        public static object[,] ToTableDataArray<T>(this T[,] source)
        {
            object[,] result = new object[source.GetLength(0), source.GetLength(1)];
            Array.Copy(source, result, source.Length);
            return result;
        }
    }

    internal struct TableDataRange
    {
        public IRange Label { get; set; }
        public IRange RowLabel { get; set; }
        public IRange ColumnLabel { get; set; }
        public IRange RowHeader { get; set; }
        public IRange ColumnHeader { get; set; }
        public IRange DataBody { get; set; }
        public IRange All { get; set; }
    }
}
