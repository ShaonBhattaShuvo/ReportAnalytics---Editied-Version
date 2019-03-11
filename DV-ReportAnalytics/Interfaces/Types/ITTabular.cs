using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITTabular { }

    internal interface ITTabular3<TRow, TColumn, TValue> : ITTabular
    {
        TRow[] Rows { get; }
        TColumn[] Columns { get; }
        TValue[] Values { get; }
    }

    internal interface ITTabularProvider<Tabular>
        where Tabular : ITTabular
    {
        // get all
        Tabular GetTabular();
    }

    internal interface ITTabularProvider3<Tabular, TRow, TColumn, TValue> : ITTabularProvider<Tabular>
        where Tabular : ITTabular3<TRow, TColumn, TValue>
    {
        // get value by range
        Tabular GetTabular(TRow[] rowRange, TColumn ColumnRange);
    }
}
