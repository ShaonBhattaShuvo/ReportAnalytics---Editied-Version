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

        // initialize with given rows, columns and values
        // row and column index must correspond with 2d list of values
        public LookupTable(string name, TKeyRow[] rows, TKeyColumn[] columns, TValue[,] values)
        {
            // TODO: throw exception if rows and columns don't match value's dimension
            Name = name;
            // IDs start with -1 if instance is empty
            _keyRowID = rows.Length - 1;
            _keyColumnID = columns.Length - 1;
            // initialize dictionary
            _keyRowDictionary = new SortedList<TKeyRow, int>();
            _keyColumnDictionary = new SortedList<TKeyColumn, int>();
            _valueDictionary = new Dictionary<(int, int), TValue>();
            for (int r = 0; r < rows.Length; r++)
            {
                _keyRowDictionary.Add(rows[r], r);
                for (int c = 0; c < columns.Length; c++)
                {
                    _keyColumnDictionary.Add(columns[c], c);
                    // add value to lookup dictionary
                    _valueDictionary.Add((r, c), values[r, c]);
                }
            }
        }

        // constructor with names
        public LookupTable(string name)
            : this (name, new TKeyRow[0], new TKeyColumn[0], new TValue[0, 0]) { }

        // default constructor
        public LookupTable() : this("untitled") { }

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
                // filter
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

        public List<TKeyRow> GetKeysRows()
        {
            return _keyRowDictionary.Keys.ToList();
        }

        public List<TKeyColumn> GetKeysColumns()
        {
            return _keyColumnDictionary.Keys.ToList();
        }

        protected void _GetXYZ(TKeyColumn[] columnRange, TKeyRow[] rowRange, out List<TKeyColumn> x, out List<TKeyRow> y, out List<List<TValue>> z)
        {
            // get x range
            if (columnRange == null)
            {
                //x = _keyColumnDictionary.Keys.ToList();
                x = GetKeysColumns();
            }
            else
            {
                // use linq to query
                //x = columnRange.Where(c => _keyColumnDictionary.Keys.Contains(c)).ToList();
                x = columnRange.ToList();
                // columnRange may not be sorted
                x.Sort();
            }
            // get y range
            if (rowRange == null)
            {
                //y = _keyRowDictionary.Keys.ToList();
                y = GetKeysRows();
            }
            else
            {
                // use linq to query
                //y = rowRange.Where(r => _keyRowDictionary.Keys.Contains(r)).ToList();
                y = rowRange.ToList();
                // rowRange may not be sorted
                y.Sort(); 
            }
            // get z
            z = new List<List<TValue>>();
            // scan by row
            foreach (TKeyRow r in y)
            {
                List<TValue> l = new List<TValue>();
                foreach (TKeyColumn c in x)
                    l.Add(this[r, c]);
                z.Add(l);
            }
           
        }

        // passing empty default value to get the whole table
        public virtual TData3<TKeyColumn, TKeyRow, TValue> GetData(TKeyColumn[] columnRange = null, TKeyRow[] rowRange = null)
        {
            _GetXYZ(columnRange, rowRange, out List<TKeyColumn> x, out List<TKeyRow> y, out List<List<TValue>> z);
            // build data
            TData3<TKeyColumn, TKeyRow, TValue> data = new TData3<TKeyColumn, TKeyRow, TValue>(x, y, z);
            return data;
        }

        //// get transposed table
        //public TData3D<TKeyRow, TKeyColumn, TValue> GetData3DTransposed(TKeyRow[] rowRange = null, TKeyColumn[] columnRange = null)
        //{
        //    GetXYZ(rowRange, columnRange, true, out List<TKeyRow> y, out List<TKeyColumn> x, out List<List<TValue>> z);
        //    // build data
        //    TData3D<TKeyRow, TKeyColumn, TValue> data = new TData3D<TKeyRow, TKeyColumn, TValue>(y, x, z);
        //    return data;
        //}

        public (int rows, int columns) GetDimension()
        {
            return (_keyRowDictionary.Count, _keyColumnDictionary.Count);
        }

    }
}
