using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Data;
using DV_ReportAnalytics.Types.Table;

namespace DV_ReportAnalytics.Models
{
    class NewTable<TKeyRow, TKeyColumn, TValue>
    {
        protected int _rowIndex;
        protected int _columnIndex;
        protected List<List<TValue>> _values;
        protected SortedList<TKeyRow, int> _rowDictionary;
        protected SortedList<TKeyColumn, int> _columnDictionary;
        protected string _rowName;
        protected string _columnName;
        protected string _name;
        protected bool _isTranposed;

        public NewTable(string name, string rowName, string columnName)
            : this (name, rowName, columnName, new List<TKeyRow>(), new List<TKeyColumn>(), new List<List<TValue>>()) { }

        // default constructor
        public NewTable() : this("untitled", "rows", "columns") { }

        // initialize with given rows, columns and values
        // row and column index must correspond with 2d list of values
        public NewTable(string name, string rowName, string columnName, List<TKeyRow> rows, List<TKeyColumn> columns, List<List<TValue>> values)
        {
            _name = name;
            _rowName = rowName;
            _columnName = columnName;
            _rowIndex = rows.Count - 1; // index starts with -1
            _columnIndex = columns.Count - 1;
            _values = values;
            _rowDictionary = new SortedList<TKeyRow, int>();
            _columnDictionary = new SortedList<TKeyColumn, int>();
            _isTranposed = false;
            // initialize dictionary
            for (int i = 0; i < rows.Count; i++)
                _rowDictionary.Add(rows[i], i);
            for (int i = 0; i < columns.Count; i++)
                _columnDictionary.Add(columns[i], i);
        }

        public void SetValue(TKeyRow row, TKeyColumn column, TValue value)
        {
            // add to dictionary
            if (!_columnDictionary.Keys.Contains(column))
            {
                _columnIndex++;
                _columnDictionary.Add(column, _columnIndex);
                // update new columns
                _values.ForEach(r => r.AddRange(new TValue[_columnDictionary.Count - r.Count]));
            }
            if (!_rowDictionary.Keys.Contains(row))
            {
                _rowIndex++;
                _rowDictionary.Add(row, _rowIndex);
                // update the new row
                _values.Add(new List<TValue>(new TValue[_columnDictionary.Count]));
            }
            // set value
            _values[_rowDictionary[row]][_columnDictionary[column]] = value;
        }
        
        public void SetTable() { }


        public Dictionary<TKeyColumn, TValue> Rows(TKeyRow[] rows) { }


        public Dictionary<TKeyRow, TValue> Columns(TKeyColumn[] columns) { }



    }
}
