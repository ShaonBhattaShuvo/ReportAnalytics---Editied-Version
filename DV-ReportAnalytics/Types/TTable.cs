using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types.Table
{
    class TTable<TKey, TElement>: Dictionary<TKey, Dictionary<TKey, TElement>>{}

    struct TDimension
    {
        public int rows;
        public int columns;
        public TDimension(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
    }

    struct THeaders<TKey>
    {
        TKey row;
        TKey column;
        public THeaders(TKey row, TKey column)
        {
            this.row = row;
            this.column = column;
        }
    }

    static class TExtension
    {
        public static TTable<TKey, TElement> ToTTable<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, Dictionary<TKey, TElement>> elementSelector)
        {
            TTable<TKey, TElement> table = new TTable<TKey, TElement>();
            foreach (TSource element in source)
                table.Add(keySelector(element), elementSelector(element));
            return table;
        }
    }
}
