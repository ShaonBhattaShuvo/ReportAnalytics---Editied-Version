using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    [Obsolete("Use improved type instead", false)]
    internal class TTable<TKey, TElement>: Dictionary<TKey, Dictionary<TKey, TElement>> {}

    [Obsolete("Use improved type instead", false)]
    internal struct TDimension
    {
        public int rows;
        public int columns;
        public TDimension(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
    }

    [Obsolete("Use improved type instead", false)]
    internal struct THeaders<TKey>
    {
        public TKey row;
        public TKey column;
        public THeaders(TKey row, TKey column)
        {
            this.row = row;
            this.column = column;
        }
    }

    [Obsolete("Use improved type extension instead", false)]
    internal static class TExtension
    {
        // extension method to get TTable from an enumerable type
        public static TTable<TKey, TElement> ToTTable<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, Dictionary<TKey, TElement>> elementSelector)
        {
            TTable<TKey, TElement> table = new TTable<TKey, TElement>();
            foreach (TSource element in source)
                table.Add(keySelector(element), elementSelector(element));
            return table;
        }
    }
}
