using System;
using System.Collections.Generic;
using System.Linq;

namespace DV_ReportAnalytics.Models
{
    internal class LookupTable<TKeyRow, TKeyColumn, TValue> : ILookupTable<TKeyRow, TKeyColumn, TValue>
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

        // initialize with given rows, columns and values
        // row and column index must correspond with 2d list of values
        public LookupTable(TKeyRow[] rows, TKeyColumn[] columns, TValue[,] values)
        {
            // TODO: throw exception if rows and columns don't match value's dimension
            
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

        // dafault constructor
        public LookupTable()
            : this(new TKeyRow[0], new TKeyColumn[0], new TValue[0, 0]) { }

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

        public (int rows, int columns) GetDimension()
        {
            return (_keyRowDictionary.Count, _keyColumnDictionary.Count);
        }

    }
}
