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
        public string Name { set; get; }
        public string KeyName { set; get; }
        public string ValueName { set; get; }
        public string KeySuffix { set; get; }
        public string ValueSuffix { set; get; }
        // the ID should always point to the last element that added into the dictionaries
        private int _keyID;
        protected Dictionary<int, TValue> _valueDictionary;
        protected SortedList<TKey, int> _keyDictionary;
        

        // initialize with given keys and values
        public LookupTable(string name, string keyName, string valueName,
            string keySuffix, string valueSuffix,
            TKey[] keys, TValue[] values)
        {
            // TODO: throw exception if keys don't match value's dimension
            Name = name;
            KeyName = keyName;
            ValueName = valueName;
            KeySuffix = keySuffix;
            ValueSuffix = valueSuffix;
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

        // constructor with name
        public LookupTable(string name)
            : this(name, "Key Label", "Value Label",
                  "", "",
                  new TKey[0], new TValue[0]) { }

        // default constructor
        public LookupTable() 
            : this("Untitled") { }

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
        public TData2<TKey, TValue> GetData(TKey[] keyRange = null)
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
            TData2<TKey, TValue> data = new TData2<TKey, TValue>(x.ToArray(), y.ToArray());
            return data;
        }

        // get dimension
        public int GetDimension()
        {
            return _keyDictionary.Count;
        }
    }
}
