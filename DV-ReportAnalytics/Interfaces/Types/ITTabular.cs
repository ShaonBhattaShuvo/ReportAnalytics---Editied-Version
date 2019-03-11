using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITTabular { }

    internal interface ITTabular3<TColumn1, TColumn2, TValue> : ITTabular
    {
        TColumn1[] Column1 { get; }
        TColumn2[] Column2 { get; }
        TValue[] ColumnValue { get; }
    }

    internal interface ITTabularProvider<Tabular>
        where Tabular : ITTabular
    {
        // get all
        Tabular GetTabular();
    }

    internal interface ITTabularProvider3<Tabular, TColumn1, TColumn2, TValue> : ITTabularProvider<Tabular>
        where Tabular : ITTabular3<TColumn1, TColumn2, TValue>
    {
        // get value by range
        Tabular GetTabular(TColumn1[] col1Range, TColumn2[] col2Range);
    }
}
