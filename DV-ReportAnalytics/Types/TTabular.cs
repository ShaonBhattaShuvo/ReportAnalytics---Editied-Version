using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    [Serializable]
    internal class TTabular3<TRow, TColumn, TValue> : ITTabular3<TRow, TColumn, TValue>
    {
        public string Name { get; }
        public string RowName { get; }
        public string RowSuffix { get; }
        public string ColumnName { get; }
        public string ColumnSuffix { get; }
        public string ValueName { get; }
        public string ValueSuffix { get; }
        public TRow[] Rows { get; }
        public TColumn[] Columns { get; }
        public TValue[] Values { get; }
        // full initialization
        public TTabular3(
            string name, string rowName, string columnName, string valueName,
            string rowSuffix, string columnSuffix, string valueSuffix,
            TRow[] rows, TColumn[] columns, TValue[] values)
        {
            Name = name;
            RowName = rowName;
            ColumnName = columnName;
            ValueName = valueName;
            RowSuffix = rowSuffix;
            ColumnSuffix = columnSuffix;
            ValueSuffix = valueSuffix;
            Rows = rows;
            Columns = columns;
            Values = values;
        }
        // initialize with values
        public TTabular3(TRow[] rows, TColumn[] columns, TValue[] values)
            : this(
                  "Untitled", "Row Label", "Column Label", "Value Label",
                  "", "", "",
                  rows, columns, values) { }
    }

    [Serializable]
    internal class TTabular3Dictionary<TRow, TColumn, TValue> : Dictionary<string, TTabular3<TRow, TColumn, TValue>> { }
}
