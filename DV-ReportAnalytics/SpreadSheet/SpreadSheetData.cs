/* 
 * Created by Fang Deng 
 * 2019/05/07
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

/* Static methods for database creation */
namespace DV_ReportAnalytics
{
    internal static class SpreadSheetData
    {
        /*
         * SUMMARY: Create a DataTable from given columns
         * @param fileds[]: This first element is taken as table name. Then the rest of them are considered as fields(columns);
         * @return System.Data.DataTable;
         * NOTE: To avoid unecessary box and unbox operations, all field types are defined as object. (Raw data from spreadsheet is object).
         */
        public static DataTable CreateDataTable(string tablename, string[] fields)
        {
            DataTable table = new DataTable(tablename);
            DataColumn col;

            for (int i = 0; i < fields.Length; i++)
            {
                col = new DataColumn();
                col.DataType = typeof(object);
                col.ColumnName = fields[i];
                col.Caption = fields[i];
                col.ReadOnly = true;
                table.Columns.Add(col);
            }
            // add value column
            col = new DataColumn();
            col.DataType = typeof(object);
            col.ColumnName = "value";
            col.Caption = "value";
            col.ReadOnly = true;
            table.Columns.Add(col);

            // TODO: set some constraints to make keys unique

            return table;
        }

        /*
         * SUMMARY: Add DataTable to DataSet. Create new DataTable if needed.
         * @param dataset: Host of DataTables;
         * @param tablename: Table Name;
         * @param fields: Table fields;
         * @param values: Table row data. Support multiple lines;
         * @return void;
         */
        public static void AddTable(this DataSet source, string tablename, string[] fields, object[] values)
        {
            if (source.Tables.Contains(tablename))
            {
                source.Tables[tablename].Rows.Add(values);
            }
            else
            {
                DataTable table = CreateDataTable(tablename, fields);
                table.Rows.Add(values);
                source.Tables.Add(table);
            }
        }

        public static TableDataSet<object> ToTableDataSet(this DataTable source, int rowfield, int colfield, int datafield)
        {
            List<object> RowHeader = new List<object>();
            List<object> ColumnHeader = new List<object>();

            foreach (DataRow row in source.Rows)
            {
                RowHeader.Add(row.Field<object>(rowfield));
                ColumnHeader.Add(row.Field<object>(colfield));
            }

            // remove duplicate item and sort
            RowHeader = RowHeader.Distinct().ToList();
            ColumnHeader = ColumnHeader.Distinct().ToList();
            RowHeader.Sort();
            ColumnHeader.Sort();

            // build data
            object[,] value = new object[RowHeader.Count, ColumnHeader.Count];
            foreach (DataRow row in source.Rows)
                value[RowHeader.IndexOf(row.Field<object>(rowfield)), ColumnHeader.IndexOf(row.Field<object>(colfield))]
                    = row.Field<object>(datafield);

            return new TableDataSet<object>()
            {
                Label = source.TableName,
                RowLabel = source.Columns[rowfield].ColumnName,
                ColumnLabel = source.Columns[colfield].ColumnName,
                RowHeader = RowHeader.ToArray(),
                ColumnHeader = ColumnHeader.ToArray(),
                DataBody = value
            };
        }

        public static TableDataSet<double> ToDouble(this TableDataSet<object> source)
        {
            double[] rowheader = new double[source.RowHeader.Length];
            double[] colheader = new double[source.ColumnHeader.Length];
            double[,] databody = new double[source.DataBody.GetLength(0), source.DataBody.GetLength(1)];
            Array.Copy(source.RowHeader, rowheader, source.RowHeader.Length);
            Array.Copy(source.ColumnHeader, colheader, source.ColumnHeader.Length);
            Array.Copy(source.DataBody, databody, source.DataBody.Length);
            return new TableDataSet<double>()
            {
                Label = source.Label,
                RowLabel = source.RowLabel,
                ColumnLabel = source.ColumnLabel,
                RowHeader = rowheader,
                ColumnHeader = colheader,
                DataBody = databody
            };
        }

        public static TableDataSet<object> ToObject<T>(this TableDataSet<T> source)
        {
            object[] rowheader = new object[source.RowHeader.Length];
            object[] colheader = new object[source.ColumnHeader.Length];
            object[,] databody = new object[source.DataBody.GetLength(0), source.DataBody.GetLength(1)];
            Array.Copy(source.RowHeader, rowheader, source.RowHeader.Length);
            Array.Copy(source.ColumnHeader, colheader, source.ColumnHeader.Length);
            Array.Copy(source.DataBody, databody, source.DataBody.Length);
            return new TableDataSet<object>()
            {
                Label = source.Label,
                RowLabel = source.RowLabel,
                ColumnLabel = source.ColumnLabel,
                RowHeader = rowheader,
                ColumnHeader = colheader,
                DataBody = databody
            };
        }

        public static int ToNumberIndex(this string source)
        {
            int result;
            try
            {
                result = Convert.ToInt32(source);
            }
            catch
            {
                char[] arr = source.ToUpper().ToArray();
                result = -1; // zero indexed
                for (int i = 0; i < arr.Length; i++)
                {
                    result = result + ((int)arr[i] - 64) * (int)Math.Pow(26d, i);
                }
            }
            return result;
        }
    }

    internal struct TableDataSet<T>
    {
        public object Label { get; set; }
        public object RowLabel { get; set; }
        public object ColumnLabel { get; set; }
        public T[] RowHeader { get; set; }
        public T[] ColumnHeader { get; set; }
        public T[,] DataBody { get; set; }
    }
}
