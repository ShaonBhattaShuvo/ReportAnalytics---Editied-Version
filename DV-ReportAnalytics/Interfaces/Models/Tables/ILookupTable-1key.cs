using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface ILookupTable<TKey, TValue>
    {
        string Name { set;  get; }
        string KeyName { set; get; }
        string ValueName { set; get; }
        string KeySuffix { set; get; }
        string ValueSuffix { set; get; }
        // use indexer to get value in a convenient way
        TValue this[TKey key] { set; get; }

        // get keys
        TKey[] GetKeys();

        // get table
        TData2<TKey, TValue> GetData(TKey[] range);

        // get the number of elements
        int GetDimension();
    }
}
