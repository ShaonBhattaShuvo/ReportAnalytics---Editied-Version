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
        List<TRow> Rows { get; }
        List<TColumn> Columns { get; }
        List<TValue> Values { get; }
    }
}
