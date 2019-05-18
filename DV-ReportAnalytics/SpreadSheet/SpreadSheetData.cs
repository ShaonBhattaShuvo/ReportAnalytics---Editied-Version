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
        public static void AddToDataSet(DataSet dataset, string tablename, string[] fields, object[] values)
        {
            if (dataset.Tables.Contains(tablename))
            {
                dataset.Tables[tablename].Rows.Add(values);
            }
            else
            {
                DataTable table = CreateDataTable(tablename, fields);
                table.Rows.Add(values);
                dataset.Tables.Add(table);
            }
        }

        public static TableDataSet<object> ConvertToTableDataSet(DataTable table, int rowfield, int colfield, int datafield)
        {
            List<object> RowHeader = new List<object>();
            List<object> ColumnHeader = new List<object>();

            foreach (DataRow row in table.Rows)
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
            foreach (DataRow row in table.Rows)
                value[RowHeader.IndexOf(row.Field<object>(rowfield)), ColumnHeader.IndexOf(row.Field<object>(colfield))]
                    = row.Field<object>(datafield);

            return new TableDataSet<object>(RowHeader.ToArray(), ColumnHeader.ToArray(), value);
        }
    }

    internal struct TableDataSet<T>
    {
        public T[] RowHeader { get; }
        public T[] ColumnHeader { get; }
        public T[,] DataBody { get; }
        public TableDataSet(T[] rowheader, T[] colheader, T[,] databody)
        {
            RowHeader = rowheader;
            ColumnHeader = colheader;
            DataBody = databody;
        }
    }
}
