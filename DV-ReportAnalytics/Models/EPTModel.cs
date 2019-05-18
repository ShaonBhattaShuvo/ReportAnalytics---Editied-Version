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
        public string Parameter { set; get; }
        public string Delimiter { set; get; }
        public string InputSheet { set; get; }
        public string OutputSheet { set; get; }
        public string Name { set; get; }
        public int ParameterColumn { set; get; }
        public int ValueColumn { set; get; }
        public string ResultPath { set; get; }
        public DataSet DataBase { get; private set; }

        public XmlDocument Settings
        {
            set
            {
                Parameter = value.GetNodeValue("Settings/ResultFormat/Parameter");
                Delimiter = value.GetNodeValue("Settings/ResultFormat/Delimiter");
                ParameterColumn = value.GetNodeValue<int>("Settings/ResultFormat/ParameterColumn");
                ValueColumn = value.GetNodeValue<int>("Settings/ResultFormat/ValueColumn");
                InputSheet = value.GetNodeValue("Settings/InputSheetName");
                OutputSheet = value.GetNodeValue("Settings/OutputSheetName");
                Name = value.GetNodeValue("Settings/Name");
                ResultPath = value.GetNodeValue("Paths/Result");
            }
        }

        public EPTModel(XmlDocument settings)
        {
            Settings = settings;
        }

        public void Build()
        {
            DataBase = new DataSet();
            IWorkbook workbook = Factory.GetWorkbook(ResultPath);
            IWorksheet worksheet = workbook.Worksheets[InputSheet];
            IRange range = worksheet.UsedRange;
            string[] fields = Parameter.Split(Delimiter.ToArray()).Skip(1).ToArray(); // skip name section

            for (int i = 0; i < range.RowCount; i++)
            {
                string[] param = range[i, ParameterColumn].Value?.ToString().Split(Delimiter.ToArray());
                if (param?.Length >= 3)
                {
                    List<object> values = new List<object>(param.Length);
                    values.AddRange(param.Skip(1)); // skip name section
                    values.Add(range[i, ValueColumn].Value);
                    SpreadSheetData.AddToDataSet(DataBase, param[0], fields, values.ToArray());
                }
            }
            Console.WriteLine("done");
        }


    }
}
