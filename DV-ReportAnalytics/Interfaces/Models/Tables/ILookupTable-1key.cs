using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface ILookupTable<Tkey, TValue>
    {
        string Name { get; }
        string keyName { get; }
        string valueName { get; }

        // use indexer to get value in a convenient way
        TValue this[Tkey key] { set; get; }

        // get table
        TData2D<Tkey, TValue> GetData2D(Tkey[] range);

        // get the number of elements
        int GetDimension();
    }
}
