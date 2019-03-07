using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    interface ITTabular3<TRow, TColumn, TValue>
    {
        string Name { get; }
        string RowName { get; }
        string RowSuffix { get; }
        string ColumnName { get; }
        string ColumnSuffix { get; }
        string ValueName { get; }
        string ValueSuffix { get; }
        TRow[] Rows { get; }
        TColumn[] Columns { get; }
        TValue[] Values { get; }
    }
}
