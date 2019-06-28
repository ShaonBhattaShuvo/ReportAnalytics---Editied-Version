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
                    else
                        throw new Exception("Invalid parameter!");
                }

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }   
        }

        public IEnumerable<TableDataCollection<object>> GetTableDataCollections(
            string[] items, int rowInterpolation = 0, int columnInterpolation = 0)
        {
            List<TableDataCollection<object>> collections = new List<TableDataCollection<object>>(items.Length);
            foreach (string name in items)
                collections.Add(DataBase.Tables[name].ToTableDataCollection(1, 0, 2));

            if (rowInterpolation == 0 && columnInterpolation == 0)
                return collections.AsEnumerable();

            // UNDONE: do interpolation
            return collections.AsEnumerable();
        }
    }
}