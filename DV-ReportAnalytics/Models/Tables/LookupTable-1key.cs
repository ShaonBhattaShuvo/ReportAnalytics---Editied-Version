using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    class LookupTable<TKey, TValue> : ILookupTable<TKey, TValue>
        where TKey : IEquatable<TKey>, IComparable<TKey>
        where TValue : new()
    {
        private int _keyID;
        protected Dictionary<int, TValue> _valueDictionary;
        protected SortedList<TKey, int> _keyDictionary;
        public string Name { get; }
        public string keyName { get; }
        public string valueName { get; }

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
                    ;
                else
                    v = new TValue();
                return v;
            }
        }

        public List<TKey> GetKeys()
        {
            return _keyDictionary.Keys.ToList();
        }

        // passing empty default value to get the whole table
        public TData2D<TKey, TValue> GetData2D(TKey[] keyRange = null)
        {
            List<TKey> x = new List<TKey>();
            List<TValue> y = new List<TValue>();
            // get x range
            if (keyRange == null)
            {
                //x = _keyDictionary.Keys.ToList();
                x = GetKeys();
            }
            else
            {
                // use linq to query
                //x = keyRange.Where(k => _keyDictionary.Keys.Contains(k)).ToList();
                x = keyRange.ToList();
                // range may not be sorted
                x.Sort();
            }
            // get y
            foreach (TKey k in x)
                y.Add(this[k]);
            // build data
            TData2D<TKey, TValue> data = new TData2D<TKey, TValue>(x, y);
            return data;
        }

        // get dimension
        public int GetDimension()
        {
            return _keyDictionary.Count;
        }
    }
}
