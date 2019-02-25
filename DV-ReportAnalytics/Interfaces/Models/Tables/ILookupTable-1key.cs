using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface ILookupTable<TKey, TValue>
    {
        string Name { get; }

        // use indexer to get value in a convenient way
        TValue this[TKey key] { set; get; }

        // get keys
        List<TKey> GetKeys();

        // get table
        TData2D<TKey, TValue> GetData2D(TKey[] range);

        // get the number of elements
        int GetDimension();
    }
}
