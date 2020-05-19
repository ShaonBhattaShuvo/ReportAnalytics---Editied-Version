using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace DV_ReportAnalytics.Core
{
    public class EPTReportModel
    {
        public DataSet Database { get; private set; }
        public string[] TableNames
        {
            get
            {
                List<string> names = new List<string>(Database.Tables.Count);
                foreach (DataTable table in Database.Tables)
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
        public void Build(object[,] dataRange, string parameter, char delimiter,
            int parameterColumn, int valueColumn, int prefix = 0)
        {
            // Shaon
            Database = new DataSet();
            int indexP = parameterColumn - 1;
            int indexV = valueColumn - 1;

            string[] fields = parameter.Split(delimiter).Skip(1).ToArray(); // skip name section
            if (prefix == 1) indexP++;
            for (int i = 0 + prefix; i < dataRange.GetLength(0) + prefix; i++)
            {
                string[] param = dataRange[i, indexP]?.ToString().Split(delimiter);
                if (param?.Length >= 3)
                {
                    List<object> values = new List<object>(param.Length);
                    values.AddRange(param.Skip(1)); // skip name section

                    if (prefix == 1)
                    {
                        values.Add(dataRange[i, indexV + 1]);
                    }
                    else
                    {
                        values.Add(dataRange[i, indexV]);
                    }
                    Database.AddTable(param[0], fields, values.ToArray());
                }
            }
        }
        public IEnumerable<TableInfo> GetTableInfoCollection(
            string[] items, int rowInterpolation = 0, int columnInterpolation = 0)
        {
            List<TableInfo> collections = new List<TableInfo>(items.Length);
            foreach (string name in items)
            {
                var table = Database.Tables[name].GetTableInfo(1, 0, 2);
                table.Interpolate(rowInterpolation, columnInterpolation);
                collections.Add(table);
            }

            return collections.AsEnumerable();
        }
    }
}