using System;
using System.Linq;
using System.Collections.Generic;
using SpreadsheetGear;
using DV_ReportAnalytics.Core;

namespace DV_ReportAnalytics.App.SpreadsheetGear
{
    internal static class SpreadSheetGear_Table
    {
        public static TableDataRange InsertTable(this IRange source, TableInfo data)
        {
            // insert title
            IRange labelRange = source.Cells[0, 0];
            labelRange.Value = data.Label;
            // insert column label
            IRange columnLabelRange = source.Cells[0, 1, 0, data.ColumnHeader.Length - 1 + 1];
            columnLabelRange.Cells[0, 0].Value = data.ColumnLabel;
            // insert row label
            IRange rowLabelRange = source.Cells[1, 0];
            rowLabelRange.Value = data.RowLabel;
            // insert column header
            IRange columnHeaderRange = source.Cells[1, 1, 1, data.ColumnHeader.Length - 1 + 1];
            columnHeaderRange.Value = data.ColumnHeader.ToRangeRowArray();
            // insert row header
            IRange rowHeaderRange = source.Cells[2, 0, data.RowHeader.Length - 1 + 2, 0];
            rowHeaderRange.Value = data.RowHeader.ToRangeColumnArray();
            // insert data body
            IRange dataBodyRange = source.Cells[2, 1,
                data.DataBody.GetLength(0) - 1 + 2,
                data.DataBody.GetLength(1) - 1 + 1];
            dataBodyRange.Value = data.DataBody;
            // table range
            IRange all = source.Cells[0, 0,
                rowLabelRange.RowCount + rowHeaderRange.RowCount,
                columnHeaderRange.ColumnCount];

            //all.Columns.AutoFit();
            //all.Rows.AutoFit();

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

        public static IEnumerable<TableDataRange> InsertTablesInNewSheet(this IWorkbook source, string outputSheet, int maxItemsPerRow,
            IEnumerable<TableInfo>tables)
        {
            source.Worksheets[outputSheet]?.Delete(); // delete old one
            IWorksheet worksheet = source.Worksheets.Add();
            worksheet.Name = outputSheet;

            IRange current = worksheet.Cells[0, 0]; // top-left cell
            int count = 0;

            List<TableDataRange> tableRanges = new List<TableDataRange>();

            foreach (var table in tables)
            {
                TableDataRange range = current.InsertTable(table);
                tableRanges.Add(range);

                // move cursor
                if (++count >= maxItemsPerRow)
                {
                    count = 0;
                    current = range.All.RowBelow().RowBelow().FirstCell();
                }
                else
                {
                    current = range.All.CellRight().CellRight();
                }
            }

            return tableRanges.AsEnumerable();
        }

        public static void ApplyHeatMap(this TableDataRange source)
        {
            Color color = Color.FromArgb(245, 245, 245);
            source.Label.Interior.Color = color;
            source.RowLabel.Interior.Color = color;
            source.RowHeader.Interior.Color = color;
            source.ColumnLabel.Interior.Color = color;
            source.ColumnHeader.Interior.Color = color;

            IFormatCondition format = source.DataBody.FormatConditions.AddColorScale(3);
            format.ColorScale.ColorScaleCriteria[0].Type = ConditionValueTypes.Percentile;
            format.ColorScale.ColorScaleCriteria[0].Value = 0;
            format.ColorScale.ColorScaleCriteria[0].FormatColor.Color = Color.FromArgb(255, 247, 188);

            format.ColorScale.ColorScaleCriteria[1].Type = ConditionValueTypes.Percentile;
            format.ColorScale.ColorScaleCriteria[1].Value = 50;
            format.ColorScale.ColorScaleCriteria[1].FormatColor.Color = Color.FromArgb(254, 196, 79);

            format.ColorScale.ColorScaleCriteria[2].Type = ConditionValueTypes.Percentile;
            format.ColorScale.ColorScaleCriteria[2].Value = 100;
            format.ColorScale.ColorScaleCriteria[2].FormatColor.Color = Color.FromArgb(217, 95, 14);
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
