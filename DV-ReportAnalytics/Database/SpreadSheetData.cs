/* 
 * Created by Fang Deng 
 * 2019/05/07
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/* Static methods for database creation */
namespace DV_ReportAnalytics.Database
{
    internal static class SpreadSheetData
    {
        /*
         * SUMMARY: Create a DataTable from given columns
         * @param fileds[]: This first element is taken as table name. Then the rest of them are considered as fields(columns);
         * @return System.Data.DataTable;
         * NOTE: For unecessary box and unbox operations, all field types are defined as object. (Raw data from spreadsheet is object).
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
    }
}
