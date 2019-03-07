using System;
using System.Collections.Generic;
using System.Linq;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    internal class LookupTable<TKeyRow, TKeyColumn, TValue> : ILookupTable<TKeyRow, TKeyColumn, TValue>
        where TKeyRow : IEquatable<TKeyRow>, IComparable<TKeyRow>
        where TKeyColumn : IEquatable<TKeyColumn>, IComparable<TKeyColumn>
        where TValue : new()
    {
        public string Name { set;  get; }
        public string KeyRowName { set; get; }
        public string KeyColumnName { set; get; }
        public string ValueName { set; get; }
        public string KeyRowSuffix { set; get; }
        public string KeyColumnSuffix { set; get; }
        public string ValueSuffix { set; get; }
        // the ID should always point to the last element that added into the dictionaries
        private int _keyRowID;
        private int _keyColumnID;
        protected Dictionary<ValueTuple<int, int>, TValue> _valueDictionary;
        protected SortedList<TKeyRow, int> _keyRowDictionary;
        protected SortedList<TKeyColumn, int> _keyColumnDictionary;

        // initialize with given rows, columns and values
        // row and column index must correspond with 2d list of values
        public LookupTable(
            string name, string rowName, string columnName, string valueName,
            string rowSuffix, string columnSuffix, string valueSuffix, 
            TKeyRow[] rows, TKeyColumn[] columns, TValue[,] values)
        {
            // TODO: throw exception if rows and columns don't match value's dimension
            Name = name;
            KeyRowName = rowName;
            KeyColumnName = columnName;
            ValueName = valueName;
            KeyRowSuffix = rowSuffix;
            KeyColumnSuffix = columnSuffix;
            ValueSuffix = valueSuffix;
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

        // constructor with name
        public LookupTable(string name)
            : this(
                  name, "Row Label", "Column Label", "Value Label",
                  "", "", "",
                  new TKeyRow[0], new TKeyColumn[0], new TValue[0, 0]) { }

        // default constructor
        public LookupTable() 
            : this("Untitled") { }

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

        public TKeyRow[] GetKeysRows()
        {
            return _keyRowDictionary.Keys.ToArray();
        }

        public TKeyColumn[] GetKeysColumns()
        {
            return _keyColumnDictionary.Keys.ToArray();
        }

        // get provided range
        protected void _GetRange(TKeyRow[] rowRange, TKeyColumn[] columnRange,  out TKeyColumn[] x, out TKeyRow[] y)
        {
            // get x range
            if (columnRange == null)
            {
                x = GetKeysColumns();
            }
            else
            {
                x = columnRange;
                // columnRange may not be sorted
                Array.Sort(x);
            }
            // get y range
            if (rowRange == null)
            {
                y = GetKeysRows();
            }
            else
            {
                y = rowRange;
                // rowRange may not be sorted
                Array.Sort(y);
            }
        }

        // get xyz values
        protected void _GetXYZ(TKeyRow[] rowRange, TKeyColumn[] columnRange, out TKeyColumn[] x, out TKeyRow[] y, out TValue[,] z)
        {
            _GetRange(rowRange, columnRange, out x, out y);
            // get z
            z = new TValue[y.Length, x.Length];
            // scan by row then by column
            for (int r = 0; r < y.Length; r++)
                for (int c = 0; c < x.Length; c++)
                    z[r, c] = this[y[r], x[c]];
        }
        // for internal use
        protected virtual TData3<TKeyColumn, TKeyRow, TValue> _GetData(TKeyColumn[] x, TKeyRow[] y, TValue[,] z)
        {
            return new TData3<TKeyColumn, TKeyRow, TValue>(x, y, z);
        }

        // get data by range
        public virtual TData3<TKeyColumn, TKeyRow, TValue> GetData(TKeyRow[] rowRange, TKeyColumn[] columnRange)
        {
            _GetXYZ(rowRange, columnRange, out TKeyColumn[] x, out TKeyRow[] y, out TValue[,] z);
            return _GetData(x, y, z);
        }

        // get all data
        public virtual TData3<TKeyColumn, TKeyRow, TValue> GetData()
        {
            return GetData(null, null);
        }

        public (int rows, int columns) GetDimension()
        {
            return (_keyRowDictionary.Count, _keyColumnDictionary.Count);
        }

    }
}
