using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types.Table
{
    class TTable<KR, KC, V>: Dictionary<KR, Dictionary<KC, V>>{}

    struct TDimension
    {
        public int rows;
        public int columns;
        TDimension(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
    }

    struct THeaders<KR, KC>
    {
        KR row;
        KC column;
        THeaders(KR row, KC column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
