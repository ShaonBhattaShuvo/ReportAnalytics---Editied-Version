using System;
using System.Collections.Generic;
using System.Linq;

namespace DV_ReportAnalytics.Models
{
    internal class LookupTable<TKey, TValue> : ILookupTable<TKey, TValue>
        where TKey : IEquatable<TKey>, IComparable<TKey>
        where TValue : new()
    {
        // the ID should always point to the last element that added into the dictionaries
        private int _keyID;
        protected Dictionary<int, TValue> _valueDictionary;
        protected SortedList<TKey, int> _keyDictionary;
        

        // initialize with given keys and values
        public LookupTable(TKey[] keys, TValue[] values)
        {
            // TODO: throw exception if keys don't match value's dimension

            // ID starts with -1 if instance is empty
            _keyID = keys.Length - 1;
            // initialize dictionary
            _keyDictionary = new SortedList<TKey, int>();
            _valueDictionary = new Dictionary<int, TValue>();
            for (int i = 0; i < keys.Length; i++)
            {
                _keyDictionary.Add(keys[i], i);
                _valueDictionary.Add(i, values[i]);
            }
        }

        // default constructor
        public LookupTable() 
            : this(new TKey[0], new TValue[0]) { }

        // indexer
        public TValue this[TKey key]
        {
            set
            {
                // update key dic
                if (_keyDictionary.Keys.Contains(key))
                {
                    _keyID++;
                    _keyDictionary.Add(key, _keyID);
                }
                // add to value dict
                _valueDictionary.Add(_keyDictionary[key], value);
            }
            get
            {
                // try to get value
                if (_keyDictionary.TryGetValue(key, out int k) &&
                    _valueDictionary.TryGetValue(k, out TValue v))
                {
                    // value can be gotten from if statement
                }
                else
                {
                    v = new TValue();
                }
                return v;
            }
        }

        public TKey[] GetKeys()
        {
            return _keyDictionary.Keys.ToArray();
        }

        public int GetDimension()
        {
            return _keyDictionary.Count;
        }
    }
}
