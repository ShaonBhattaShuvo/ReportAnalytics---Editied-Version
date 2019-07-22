/* +---------------------
 * Created by Fang Deng 
 * 2019/05/07
 * +---------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

/* Static methods for database creation */
namespace DV_ReportAnalytics.Core
{
    /// <summary>
    /// SpreadSheet data related
    /// </summary>
    public static partial class DataSetExtensions
    {
        /// <summary>
        /// Create a DataTable from given columns
        /// NOTE: To avoid unecessary box and unbox operations, all field types are defined as object. (Raw data from spreadsheet is object).
        /// </summary>
        /// <param name="tablename">Name of the table</param>
        /// <param name="fields">This first element is taken as table name. Then the rest of them are considered as fields(columns)</param>
        /// <returns>New table</returns>
        private static DataTable CreateDataTable(string tablename, string[] fields)
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

        /// <summary>
        /// Add DataTable to DataSet. Create new DataTable if needed.
        /// </summary>
        /// <param name="source">Host of DataTables</param>
        /// <param name="tablename">Name of the table</param>
        /// <param name="fields">Table fields</param>
        /// <param name="values">Table row data. Support multiple lines</param>
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

        /// <summary>
        /// Converter for DataTable to TableInfo
        /// </summary>
        /// <param name="source"></param>
        /// <param name="rowfield"></param>
        /// <param name="colfield"></param>
        /// <param name="datafield"></param>
        /// <returns></returns>
        public static TableInfo GetTableInfo(this DataTable source, int rowfield, int colfield, int datafield)
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

            return new TableInfo()
            {
                Label = source.TableName,
                RowLabel = source.Columns[rowfield].ColumnName,
                ColumnLabel = source.Columns[colfield].ColumnName,
                RowHeader = RowHeader.ToArray(),
                ColumnHeader = ColumnHeader.ToArray(),
                DataBody = value
            };
        }

        /// <summary>
        /// In-place interpolation for TableInfo
        /// </summary>
        /// <param name="source"></param>
        /// <param name="rowInterp"></param>
        /// <param name="colInterp"></param>
        public static void Interpolate(ref this TableInfo source, int rowInterp, int colInterp)
        {
            double[] xi = source.ColumnHeader.ToArray<object, double>();
            double[] yi = source.RowHeader.ToArray<object, double>();
            double[,] zi = source.DataBody.ToArray<object, double>();
            // check dimension if match
            if (yi.GetLength(0) != zi.GetLength(0) || xi.GetLength(0) != zi.GetLength(1))
                throw new Exception("Dimensions are not matched!");

            double[] xo = Interpolation.ExtendArray(xi, colInterp);
            double[] yo = Interpolation.ExtendArray(yi, rowInterp);
            object[,] zo = new object[yo.Length, xo.Length];

            // destination points
            double dstX;
            double dstY;
            for (int y = 0; y < yo.Length; y++)
            {
                dstY = yo[y];
                for (int x = 0; x < xo.Length; x++)
                {
                    dstX = xo[x];
                    zo[y, x] = Interpolation.BilinearInterpolation(xi, yi, zi, dstX, dstY);
                }
            }
           
            source.ColumnHeader = xo.ToArray<double, object>();
            source.RowHeader = yo.ToArray<double, object>();
            source.DataBody = zo;
        }
    }

    public struct TableInfo
    {
        public object Label { get; set; }
        public object RowLabel { get; set; }
        public object ColumnLabel { get; set; }
        public object[] RowHeader { get; set; }
        public object[] ColumnHeader { get; set; }
        public object[,] DataBody { get; set; }
    }
}