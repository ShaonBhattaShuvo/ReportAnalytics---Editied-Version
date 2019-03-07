using System;
using System.Collections.Generic;
using System.Linq;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Models
{
    [Obsolete("Use LookupTable instead", false)]
    internal class CrossTable<TKeyRow, TKeyColumn, TValue> : ICrossTable<TKeyRow, TKeyColumn, TValue>
        where TKeyRow : new()
        where TKeyColumn : new()
        where TValue : new()
    {
        private int _rowIndex;
        private int _columnIndex;
        protected List<List<TValue>> _values;
        protected SortedList<TKeyRow, int> _rowDictionary;
        protected SortedList<TKeyColumn, int> _columnDictionary;
        public string RowName { get; }
        public string Name { get; }
        public string ColumnName { get; }

        public CrossTable(string name, string rowName, string columnName)
            : this (name, rowName, columnName, new List<TKeyRow>(), new List<TKeyColumn>(), new List<List<TValue>>()) { }

        // default constructor
        public CrossTable() : this("untitled", "rows", "columns") { }

        // initialize with given rows, columns and values
        // row and column index must correspond with 2d list of values
        public CrossTable(string name, string rowName, string columnName, List<TKeyRow> rows, List<TKeyColumn> columns, List<List<TValue>> values)
        {
            Name = name;
            RowName = rowName;
            ColumnName = columnName;
            _rowIndex = rows.Count - 1; // index starts with -1
            _columnIndex = columns.Count - 1;
            _values = values;
            _rowDictionary = new SortedList<TKeyRow, int>();
            _columnDictionary = new SortedList<TKeyColumn, int>();
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
                _values.ForEach(r => r.Add(new TValue()));
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

        public TValue GetValue(TKeyRow row, TKeyColumn column)
        {
            TValue v;
            if (_rowDictionary.TryGetValue(row, out int r) && _columnDictionary.TryGetValue(column, out int c))
                v = _values[r][c];
            else
                v = new TValue(); // if does not exit, return uninitialized value;
            return v;
        }

        private void GetXYZ(TKeyRow[] rowRange, TKeyColumn[] columnRange, bool transposed, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z)
        {
            // get y range
            if (rowRange == null)
                y = _rowDictionary.Keys.ToList();
            else
            {
                y = rowRange.Where(r => _rowDictionary.Keys.Contains(r)).ToList();
                y.Sort(); // rowRange may not be sorted
            }
            // get x range
            if (columnRange == null)
                x = _columnDictionary.Keys.ToList();
            else
            {
                x = columnRange.Where(c => _columnDictionary.Keys.Contains(c)).ToList();
                x.Sort(); // columnRange may not be sorted
            }
            // get z
            z = new List<List<TValue>>();
            // if it is transposed
            // scan by column
            if (transposed)
            {
                foreach (TKeyColumn c in x)
                {
                    List<TValue> l = new List<TValue>();
                    foreach (TKeyRow r in y)
                        l.Add(GetValue(r, c));
                    z.Add(l);
                }
            }
            // or scan by row
            else
            {
                foreach (TKeyRow r in y)
                {
                    List<TValue> l = new List<TValue>();
                    foreach (TKeyColumn c in x)
                        l.Add(GetValue(r, c));
                    z.Add(l);
                }
            }
        }

        public TData3<TKeyColumn, TKeyRow, TValue> GetData3D(TKeyRow[] rowRange = null, TKeyColumn[] columnRange = null)
        {
            GetXYZ(rowRange, columnRange, false, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z);
            // build data
            TData3<TKeyColumn, TKeyRow, TValue> data = new TData3<TKeyColumn, TKeyRow, TValue>(x.ToArray(), y.ToArray(), z.To2DArray());
            return data;
        }

        public TData3<TKeyRow, TKeyColumn, TValue> GetData3DTransposed(TKeyRow[] rowRange = null, TKeyColumn[] columnRange = null)
        {
            GetXYZ(rowRange, columnRange, true, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z);
            // build data
            TData3<TKeyRow, TKeyColumn, TValue> data = new TData3<TKeyRow, TKeyColumn, TValue>(y.ToArray(), x.ToArray(), z.To2DArray());
            return data;
        }

        public (int rows, int columns) GetDimension()
        {
            return (_rowDictionary.Count, _columnDictionary.Count);
        }

    }
}
