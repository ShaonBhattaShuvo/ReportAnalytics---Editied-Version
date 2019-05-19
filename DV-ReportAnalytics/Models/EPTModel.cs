using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Data;
using SpreadsheetGear;

namespace DV_ReportAnalytics
{
    internal class EPTModel
    {
        private string _outputSheet;
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

        public EPTModel()
        {
        }

        public void Build(string input, XmlDocument settings)
        {
            string parameter = settings.GetNodeValue("Settings/ResultFormat/Parameter");
            string delimiter = settings.GetNodeValue("Settings/ResultFormat/Delimiter");
            int parameterColumn = settings.GetNodeValue<int>("Settings/ResultFormat/ParameterColumn");
            int valueColumn = settings.GetNodeValue<int>("Settings/ResultFormat/ValueColumn");
            string inputSheet = settings.GetNodeValue("Settings/InputSheetName");
            _outputSheet = settings.GetNodeValue("Settings/OutputSheetName");
            DataBase = new DataSet();
            IWorkbook workbook = Factory.GetWorkbook(input);
            IWorksheet worksheet = workbook.Worksheets[inputSheet];
            IRange range = worksheet.UsedRange;
            string[] fields = parameter.Split(delimiter.ToArray()).Skip(1).ToArray(); // skip name section

            for (int i = 0; i < range.RowCount; i++)
            {
                string[] param = range[i, parameterColumn].Value?.ToString().Split(delimiter.ToArray());
                if (param?.Length >= 3)
                {
                    List<object> values = new List<object>(param.Length);
                    values.AddRange(param.Skip(1)); // skip name section
                    values.Add(range[i, valueColumn].Value);
                    DataBase.AddTable(param[0], fields, values.ToArray());
                }
            }
            workbook.Close();
        }

        public void Draw(string input)
        {
            IWorkbook workbook = Factory.GetWorkbook(input);
            workbook.Worksheets[_outputSheet]?.Delete(); // delete old one
            IWorksheet worksheet = workbook.Worksheets.Add();
            worksheet.Name = _outputSheet;

            IRange topLeft = worksheet.Cells[0, 0]; // top-left cell
            IRange current = topLeft;
            int count = 0;

            foreach (string name in TableNames)
            {
                TableDataRange ranges = current.InsertTable(DataBase.Tables[name].ToTableDataSet(0, 1, 2));
                if (++count > 3)
                {
                    count = 0;
                    current = ranges.All.RowBelow().RowBelow().FirstCell();
                }
                else
                {
                    current = ranges.All.CellRight().CellRight();
                }
            }

            workbook.SaveAs("ept.xlsx", FileFormat.OpenXMLWorkbook);
            workbook.Close();
        }


    }
}
