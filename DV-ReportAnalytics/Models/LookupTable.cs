using System;
using System.Collections.Generic;
using System.Linq;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    class LookupTable<TKeyRow, TKeyColumn, TValue> : ILookupTable<TKeyRow, TKeyColumn, TValue>
        where TKeyRow : IEquatable<TKeyRow>, IComparable<TKeyRow>
        where TKeyColumn : IEquatable<TKeyColumn>, IComparable<TKeyColumn>
        where TValue : new()
    {
        private int _rowIndex;
        private int _columnIndex;
        protected Dictionary<ValueTuple<int, int>, TValue> _valueDictionary;
        protected SortedList<TKeyRow, int> _rowDictionary;
        protected SortedList<TKeyColumn, int> _columnDictionary;
        public string RowName { get; }
        public string Name { get; }
        public string ColumnName { get; }

        public LookupTable(string name, string rowName, string columnName)
            : this (name, rowName, columnName, new List<TKeyRow>(), new List<TKeyColumn>(), new List<List<TValue>>()) { }

        // default constructor
        public LookupTable() : this("untitled", "rows", "columns") { }

        // initialize with given rows, columns and values
        // row and column index must correspond with 2d list of values
        public LookupTable(string name, string rowName, string columnName, List<TKeyRow> rows, List<TKeyColumn> columns, List<List<TValue>> values)
        {
            // TODO: throw exception if rows and columns don't match value's dimension
            Name = name;
            RowName = rowName;
            ColumnName = columnName;
            // initialize dictionary
            _rowDictionary = new SortedList<TKeyRow, int>();
            _columnDictionary = new SortedList<TKeyColumn, int>();
            _valueDictionary = new Dictionary<(int, int), TValue>();
            // index starts with -1 if instance is empty
            _rowIndex = -1;
            _columnIndex = -1;
            foreach(TKeyRow r in rows)
            {
                _rowIndex++;
                _rowDictionary.Add(r, _rowIndex);
                foreach(TKeyColumn c in columns)
                {
                    _columnIndex++;
                    _columnDictionary.Add(c, _columnIndex);
                    // add value to lookup dictionary
                    _valueDictionary.Add((_rowIndex, _columnIndex), values[_rowIndex][_columnIndex]);
                }
            }
        }

        // provide a convenient way to access table using index
        public TValue this[TKeyRow row, TKeyColumn column]
        {
            set
            {
                // update rows and columns
                if (!_rowDictionary.Keys.Contains(row))
                {
                    _rowIndex++;
                    _rowDictionary.Add(row, _rowIndex);
                }
                if (!_columnDictionary.Keys.Contains(column))
                {
                    _columnIndex++;
                    _columnDictionary.Add(column, _columnIndex);
                }
                // add to dictionary
                _valueDictionary.Add((_rowDictionary[row], _columnDictionary[column]), value);
            }
            get
            {
                if (_rowDictionary.TryGetValue(row, out int r) &&
                    _columnDictionary.TryGetValue(column, out int c) &&
                    _valueDictionary.TryGetValue((r, c), out TValue v))
                    ; // value can be gotten from if statement
                else
                    // if does not exit, return uninitialized value;
                    v = new TValue(); 
                return v;
            }
        }

        private void GetXYZ(TKeyRow[] rowRange, TKeyColumn[] columnRange, bool transposed, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z)
        {
            // get x range
            if (columnRange == null)
                x = _columnDictionary.Keys.ToList();
            else
            {
                // use linq to query
                x = columnRange.Where(c => _columnDictionary.Keys.Contains(c)).ToList();
                x.Sort(); // columnRange may not be sorted
            }
            // get y range
            if (rowRange == null)
                y = _rowDictionary.Keys.ToList();
            else
            {
                // use linq to query
                y = rowRange.Where(r => _rowDictionary.Keys.Contains(r)).ToList();
                y.Sort(); // rowRange may not be sorted
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
                        l.Add(this[r, c]);
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
                        l.Add(this[r, c]);
                    z.Add(l);
                }
            }
        }

        // passing empty default value to get the whole table
        public TData3D<TKeyColumn, TKeyRow, TValue> GetData3D(TKeyRow[] rowRange = null, TKeyColumn[] columnRange = null)
        {
            GetXYZ(rowRange, columnRange, false, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z);
            // build data
            TData3D<TKeyColumn, TKeyRow, TValue> data = new TData3D<TKeyColumn, TKeyRow, TValue>(x, y, z);
            return data;
        }

        // get transposed table
        public TData3D<TKeyRow, TKeyColumn, TValue> GetData3DTransposed(TKeyRow[] rowRange = null, TKeyColumn[] columnRange = null)
        {
            GetXYZ(rowRange, columnRange, true, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z);
            // build data
            TData3D<TKeyRow, TKeyColumn, TValue> data = new TData3D<TKeyRow, TKeyColumn, TValue>(y, x, z);
            return data;
        }

        public (int rows, int columns) GetDimension()
        {
            return (_rowDictionary.Count, _columnDictionary.Count);
        }

    }
}
