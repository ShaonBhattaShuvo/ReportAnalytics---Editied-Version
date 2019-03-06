using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Algorithms;

namespace DV_ReportAnalytics.Models
{
    class EptTable : LookupTable<double, double, double>, IEptTable
    {
        public string KeyRowName { set; get; }
        public string KeyColumnName { set; get; }
        public string ValueName { set; get; }
        public string KeyRowSuffix { set; get; }
        public string KeyColumnSuffix { set; get; }
        public string ValueSuffix { set; get; }

        // initialize all properties
        public EptTable(string name, string rowName, string columnName, string valueName, 
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
        public EptTable() : this("untitled", "", "", "", "", "", "", new double[0], new double[0], new double[0, 0]) { }

        // hide the base method because it uses new return type
        public TEptData GetData(double[] rowRange = null, double[] columnRange = null)
        {
            GetXYZ(columnRange, rowRange, out List<double> x, out List<double> y, out List<List<double>> z);
            TEptData data = new TEptData(x, y, z);
            return data;
        }
    }
}
