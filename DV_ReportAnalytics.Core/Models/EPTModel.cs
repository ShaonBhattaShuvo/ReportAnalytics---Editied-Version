using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Data;

namespace DV_ReportAnalytics.Core.Models
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

        public EPTReportModel()
        {
        }

        /// <summary>
        /// Build EPT data model
        /// </summary>
        /// <param name="dataRange">Used range of input data</param>
        /// <param name="parameter">Parameter</param>
        /// <param name="delimiter">Delimiter used to split  parameter</param>
        /// <param name="parameterColumn">Zero-indexed integer</param>
        /// <param name="valueColumn">Zero-indexed integer</param>
        /// <returns></returns>
        public int Build(object[,] dataRange, string parameter, char delimiter,
            int parameterColumn, int valueColumn)
        {
            DataBase = new DataSet();
            
            try
            {
                string[] fields = parameter.Split(delimiter).Skip(1).ToArray(); // skip name section

                for (int i = 0; i < dataRange.GetLength(0); i++)
                {
                    string[] param = dataRange[i, parameterColumn]?.ToString().Split(delimiter);
                    if (param?.Length >= 3)
                    {
                        List<object> values = new List<object>(param.Length);
                        values.AddRange(param.Skip(1)); // skip name section
                        values.Add(dataRange[i, valueColumn]);
                        DataBase.AddTable(param[0], fields, values.ToArray());
                    }
                }

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            

            
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
                TableDataRange ranges = current.InsertTable(DataBase.Tables[name].ToTableDataCollection(1, 0, 2));
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