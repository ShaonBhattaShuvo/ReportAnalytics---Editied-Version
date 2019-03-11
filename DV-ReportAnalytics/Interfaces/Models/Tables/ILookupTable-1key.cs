using System;

namespace DV_ReportAnalytics.Models
{
    internal interface ILookupTable<TKey, TValue>
    {
        // use indexer to get value in a convenient way
        TValue this[TKey key] { set; get; }

        // get keys
        TKey[] GetKeys();

        // get the number of elements
        int GetDimension();
    }
}
