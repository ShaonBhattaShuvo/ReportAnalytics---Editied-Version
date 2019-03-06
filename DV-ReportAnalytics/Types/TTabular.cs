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
        public List<TRow> Row { get; }
        public List<TColumn> Column { get; }
        public List<TValue> Value { get; }

        public TTabular3(string name, string rowName, string columnName, string valueName,
            string rowSuffix, string columnSuffix, string valueSuffix,
            List<TRow> row, List<TColumn> column, List<TValue> value)
        {
            Name = name;
            RowName = rowName;
            ColumnName = columnName;
            ValueName = valueName;
            RowSuffix = rowSuffix;
            ColumnSuffix = columnSuffix;
            ValueSuffix = valueSuffix;
            Row = row;
            Column = column;
            Value = value;
        }
    }
}
