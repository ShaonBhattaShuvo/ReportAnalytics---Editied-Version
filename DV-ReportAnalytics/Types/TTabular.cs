using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    class TTabular3<TRow, TColumn, TValue> : ITTabular3<TRow, TColumn, TValue>
    {
        public string Name { get; }
        public string RowName { get; }
        public string RowSuffix { get; }
        public string ColumnName { get; }
        public string ColumnSuffix { get; }
        public string ValueName { get; }
        public string ValueSuffix { get; }
        public List<TRow> Rows { get; }
        public List<TColumn> Columns { get; }
        public List<TValue> Values { get; }
        // full initialization
        public TTabular3(string name, string rowName, string columnName, string valueName,
            string rowSuffix, string columnSuffix, string valueSuffix,
            List<TRow> rows, List<TColumn> columns, List<TValue> values)
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
        public TTabular3(List<TRow> rows, List<TColumn> columns, List<TValue> values)
            : this("Untitled", "Row Label", "Column Label", "Value Label",
                  "", "", "",
                  rows, columns, values) { }
    }
}
