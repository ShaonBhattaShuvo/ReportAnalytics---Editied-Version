﻿using System;

namespace DV_ReportAnalytics.Models
{
    class ResultTable : LookupTable<double, double, double>, IResultTable<double, double, double>
    {
        public string KeyRowName { set; get; }
        public string KeyColumnName { set; get; }
        public string ValueName { set; get; }
        public string KeyRowSuffix { set; get; }
        public string KeyColumnSuffix { set; get; }
        public string ValueSuffix { set; get; }

        // initialize all properties
        public ResultTable(string name, string rowName, string columnName, string valueName, 
            string rowSuffix, string columnSuffix, string valueSuffix,
            double[] rows, double[] columns, double[,] values)
            : base(name, rows, columns, values)
        {
            KeyRowName = rowName;
            KeyColumnName = columnName;
            ValueName = valueName;
            KeyRowSuffix = rowSuffix;
            KeyColumnSuffix = columnSuffix;
            ValueSuffix = valueSuffix;
        }

        // default constructor
        public ResultTable() : this("untitled", "", "", "", "", "", "", new double[0], new double[0], new double[0, 0]) { }
    }
}
