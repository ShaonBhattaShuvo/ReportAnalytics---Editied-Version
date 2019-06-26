using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Data;
using SpreadsheetGear;

namespace DV_ReportAnalytics
{
    internal class EPTReportModel
    {
        public DataSet DataBase { get; private set; }
        public string[] TableNames
        {
            get
            {
                List<string> names = new List<string>(DataBase.Tables.Count);
                foreach (DataTable table in DataBase.Tables)
                    names.Add(table.TableName);
                return names.ToArray();
            }
        }
        public event EventHandler<WorkbookUpdateEventArgs> WorkbookUpdated;

        public EPTReportModel()
        {
        }

        /// <summary>
        /// Build EPT data model
        /// </summary>
        /// <param name="file">Input file</param>
        /// <param name="parameter">Parameter</param>
        /// <param name="delimiter">Delimiter used to split  parameter</param>
        /// <param name="parameterColumn">Zero-indexed integer</param>
        /// <param name="valueColumn">Zero-indexed integer</param>
        /// <param name="inputSheet">Input sheet</param>
        /// <returns></returns>
        public IWorkbook Build(string file, string parameter, char delimiter,
            int parameterColumn, int valueColumn, string inputSheet)
        {
            DataBase = new DataSet();
            IWorkbook workbook = Factory.GetWorkbook(file);
            IWorksheet worksheet = workbook.Worksheets[inputSheet];
            IRange range = worksheet.UsedRange;
            string[] fields = parameter.Split(delimiter).Skip(1).ToArray(); // skip name section

            for (int i = 0; i < range.RowCount; i++)
            {
                string[] param = range[i, parameterColumn].Value?.ToString().Split(delimiter);
                if (param?.Length >= 3)
                {
                    List<object> values = new List<object>(param.Length);
                    values.AddRange(param.Skip(1)); // skip name section
                    values.Add(range[i, valueColumn].Value);
                    DataBase.AddTable(param[0], fields, values.ToArray());
                }
            }

            return workbook;
        }

        public IWorkbook Draw(string file, string outputSheet, string[] items,
            int rowInterpolation, int columnInterpolation, int maxItems)
        {
            IWorkbook workbook = Factory.GetWorkbook(file);
            workbook.Worksheets[outputSheet]?.Delete(); // delete old one
            IWorksheet worksheet = workbook.Worksheets.Add();
            worksheet.Name = outputSheet;

            IRange topLeft = worksheet.Cells[0, 0]; // top-left cell
            IRange current = topLeft;
            int count = 0;

            foreach (string name in items)
            {
                TableDataRange ranges = current.InsertTable(DataBase.Tables[name].ToTableDataSet(1, 0, 2));
                SpreadSheet.ApplyHeatMap(ranges);
                if (++count > maxItems)
                {
                    count = 0;
                    current = ranges.All.RowBelow().RowBelow().FirstCell();
                }
                else
                {
                    current = ranges.All.CellRight().CellRight();
                }
            }

            return workbook;
        }
    }
}