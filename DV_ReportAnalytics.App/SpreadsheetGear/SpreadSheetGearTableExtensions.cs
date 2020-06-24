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
            //AddImage to the sheet
            string[] plot_names = new string[] {"Copper_Loss", "Output_Power", "Input_Power", "Rotational_Loss", "Total_Loss","DC_Power",
                "Calculated_System_Efficiency", "Calculated_Motor_Efficiency", "Calculated_Inverter_Efficiency", "Inverter_Loss", "Motor_Loss",
                "System_Loss", "CurrentArms", "CurrentArmsAvr"};
            for (int i = 0,t=1155; i < plot_names.Length; i++)
            {
                System.String imageFile = @"C:\Temp\DV_Imagefiles\" + plot_names[i]+".png";
                // Get the width and height of the picture in pixels and convert to 
                // points for use in the call to AddPicture.  This step is only 
                // necessary if the actual picture size is to be used and that size 
                // is unknown.  Another option is to calculate the width and height  
                // in row and column coordinates in the same manner as left and top below. 
                double width;
                double height;
                System.Drawing.Image image = System.Drawing.Image.FromFile(imageFile);
                using (image)
                {
                    width = image.Width * 72.0 / image.HorizontalResolution;
                    height = image.Height * 72.0 / image.VerticalResolution;
                }

                // Calculate the left and top placement of the picture by converting  
                // row and column coordinates to points.  Use fractional values to  
                // get coordinates anywhere in between row and column boundaries. 
                //SpreadsheetGear.IWorksheetWindowInfo windowInfo = worksheet.WindowInfo;
                // Convert from the center of column B to points. 
                //double left = windowInfo.ColumnToPoints(1.5);
                // Convert from the center of row 1 to points. 
                //double top = windowInfo.RowToPoints(1.5);

                // Add the picture from file. 
                //worksheet.Shapes.AddPicture(imageFile, left, top, width, height); 
                //in Excel each cell has approximate width = 15 and height = 50 
                if (i % 2 == 0)
                {
                    worksheet.Shapes.AddPicture(imageFile, 1.5, t, 253, 250);
                }
                else
                {
                    worksheet.Shapes.AddPicture(imageFile, 251.5, t, 253, 250);
                    t = t + 234; //t = t+251 (without overlap)
                }
            }
            return tableRanges.AsEnumerable();
        }
        public static void ApplyHeatMap(this TableDataRange source, Color low, Color mid, Color high)
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
            format.ColorScale.ColorScaleCriteria[0].FormatColor.Color = low;

            format.ColorScale.ColorScaleCriteria[1].Type = ConditionValueTypes.Percentile;
            format.ColorScale.ColorScaleCriteria[1].Value = 50;
            format.ColorScale.ColorScaleCriteria[1].FormatColor.Color = mid;

            format.ColorScale.ColorScaleCriteria[2].Type = ConditionValueTypes.Percentile;
            format.ColorScale.ColorScaleCriteria[2].Value = 100;
            format.ColorScale.ColorScaleCriteria[2].FormatColor.Color = high;
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
