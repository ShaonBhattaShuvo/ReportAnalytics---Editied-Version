using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types.Table
{
    class TTable<K, V>: Dictionary<K, Dictionary<K, V>>{}

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

    struct THeaders<K>
    {
        K row;
        K column;
        public THeaders(K row, K column)
        {
            this.row = row;
            this.column = column;
        }
    }

    
}
