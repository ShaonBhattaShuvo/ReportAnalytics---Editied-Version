using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITTabular3<TRow, TColumn, TValue>
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
