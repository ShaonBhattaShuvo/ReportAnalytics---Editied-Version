using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Data;

namespace DV_ReportAnalytics.Models
{
    class NewTable<TKeyRow, TKeyColumn, TValue>
    {
        protected DataSet _dataSet;
        protected DataTable _rows;
        protected DataTable _columns;
        protected DataTable _data;
        protected bool isTranposed;

        NewTable(string tableName, string rowName, string columnName)
        {
            DataColumn column;
            // initialize data table;
            _data = new DataTable(tableName);
            column = new DataColumn("id");
            column.DataType = typeof(int);
            column.Caption = "ID";
            column.AutoIncrement = true;
            column.Unique = true;
            column.ReadOnly = true;
            _data.Columns.Add(column);

            column = new DataColumn("row_id");
            column.DataType = typeof(int);
            column.Caption = "Row";
            _data.Columns.Add(column);

            column = new DataColumn("column_id");
            column.DataType = typeof(int);
            column.Caption = "Column";
            _data.Columns.Add(column);

            column = new DataColumn("value");
            column.DataType = typeof(TValue);
            column.Caption = "Value";
            _data.Columns.Add(column);

            // initialize row table
            _rows = new DataTable(rowName);
            column = new DataColumn("id");
            column.DataType = typeof(int);
            column.Caption = "ID";
            column.AutoIncrement = true;
            column.Unique = true;
            column.ReadOnly = true;
            _rows.Columns.Add(column);

            column = new DataColumn("key");
            column.DataType = typeof(TKeyRow);
            column.Caption = "Key";
            _rows.Columns.Add(column);

            // initialize column table
            _columns = new DataTable(columnName);
            column = new DataColumn("id");
            column.DataType = typeof(int);
            column.Caption = "ID";
            column.AutoIncrement = true;
            column.Unique = true;
            column.ReadOnly = true;
            _columns.Columns.Add(column);

            column = new DataColumn("key");
            column.DataType = typeof(TKeyColumn);
            column.Caption = "Key";
            _columns.Columns.Add(column);

            // create relations
            _dataSet = new DataSet();
            DataRelation relation; 
            relation = new DataRelation("id2row", _data.Columns["row_id"], _rows.Columns["id"]);
            _dataSet.Relations.Add(relation);
            relation = new DataRelation("id2column", _data.Columns["column_id"], _columns.["id"]);
            _dataSet.Relations.Add(relation);
        }

        NewTable() : this("untitled", "rows", "columns") { }

        public void SetValue(TKeyRow row, TKeyColumn column, TValue value) { }
        
        public void SetTable() { }


        public Dictionary<TKeyColumn, TValue> Rows(TKeyRow[] rows) { }


        public Dictionary<TKeyRow, TValue> Columns(TKeyColumn[] columns) { }



    }
}
