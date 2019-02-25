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
        // the ID should always point to the last element that added into the dictionaries
        private int _keyRowID;
        private int _keyColumnID;
        protected Dictionary<ValueTuple<int, int>, TValue> _valueDictionary;
        protected SortedList<TKeyRow, int> _keyRowDictionary;
        protected SortedList<TKeyColumn, int> _keyColumnDictionary;
        public string Name { get; }
        public string keyRowName { get; }
        public string keyColumnName { get; }
        public string ValueName { get; }

        public LookupTable(string name, string rowName, string columnName, string valueName)
            : this (name, rowName, columnName, valueName, new List<TKeyRow>(), new List<TKeyColumn>(), new List<List<TValue>>()) { }

        // default constructor
        public LookupTable() : this("untitled", "rows", "columns", "values") { }

        // initialize with given rows, columns and values
        // row and column index must correspond with 2d list of values
        public LookupTable(string name, string rowName, string columnName, string valueName, List<TKeyRow> rows, List<TKeyColumn> columns, List<List<TValue>> values)
        {
            // TODO: throw exception if rows and columns don't match value's dimension
            Name = name;
            keyRowName = rowName;
            keyColumnName = columnName;
            ValueName = valueName;
            // initialize dictionary
            _keyRowDictionary = new SortedList<TKeyRow, int>();
            _keyColumnDictionary = new SortedList<TKeyColumn, int>();
            _valueDictionary = new Dictionary<(int, int), TValue>();
            // ID start with -1 if instance is empty
            _keyRowID = rows.Count - 1;
            _keyColumnID = columns.Count - 1;

            for (int r = 0; r < rows.Count; r++)
            {
                _keyRowDictionary.Add(rows[r], r);
                for (int c = 0; c < columns.Count; c++)
                {
                    _keyColumnDictionary.Add(columns[c], c);
                    // add value to lookup dictionary
                    _valueDictionary.Add((r, c), values[r][c]);
                }
            }
        }

        // provide a convenient way to access table using index
        public TValue this[TKeyRow row, TKeyColumn column]
        {
            set
            {
                // update rows and columns
                if (!_keyRowDictionary.Keys.Contains(row))
                {
                    _keyRowID++;
                    _keyRowDictionary.Add(row, _keyRowID);
                }
                if (!_keyColumnDictionary.Keys.Contains(column))
                {
                    _keyColumnID++;
                    _keyColumnDictionary.Add(column, _keyColumnID);
                }
                // add to dictionary
                _valueDictionary.Add((_keyRowDictionary[row], _keyColumnDictionary[column]), value);
            }
            get
            {
                if (_keyRowDictionary.TryGetValue(row, out int r) &&
                    _keyColumnDictionary.TryGetValue(column, out int c) &&
                    _valueDictionary.TryGetValue((r, c), out TValue v))
                {
                    // value can be gotten from if statement
                }
                else
                {
                    // if does not exit, return uninitialized value;
                    v = new TValue();
                }
                return v;
            }
        }

        private void GetXYZ(TKeyRow[] rowRange, TKeyColumn[] columnRange, bool transposed, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z)
        {
            // get x range
            if (columnRange == null)
            {
                x = _keyColumnDictionary.Keys.ToList();
            }
            else
            {
                // use linq to query
                x = columnRange.Where(c => _keyColumnDictionary.Keys.Contains(c)).ToList();
                // columnRange may not be sorted
                x.Sort();
            }
            // get y range
            if (rowRange == null)
            {
                y = _keyRowDictionary.Keys.ToList();
            }
            else
            {
                // use linq to query
                y = rowRange.Where(r => _keyRowDictionary.Keys.Contains(r)).ToList();
                // rowRange may not be sorted
                y.Sort(); 
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
            return (_keyRowDictionary.Count, _keyColumnDictionary.Count);
        }

    }
}
