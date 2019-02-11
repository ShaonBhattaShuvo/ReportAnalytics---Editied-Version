using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types.Table
{
    class Table<KR, KC, V>: Dictionary<KR, Dictionary<KC, V>>{}

    struct Dimension
    {
        int rows;
        int columns;
    }

    struct Headers<KR, KC>
    {
        KR row;
        KC column;
    }
}
