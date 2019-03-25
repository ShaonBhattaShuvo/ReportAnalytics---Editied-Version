using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    [Serializable]
    internal struct TEptData3 : ITEptData3
    {
        public string Name { get; }
        public string XName { get; }
        public string XSuffix { get; }
        public string YName { get; }
        public string YSuffix { get; }
        public string ZName { get; }
        public string ZSuffix { get; }
        public double[] X { get; }
        public double[] Y { get; }
        public double[,] Z { get; }
        // full initialization
        public TEptData3(string name, string xName, string yName, string zName,
            string xSuffix, string ySuffix, string zSuffix,
            double[] x, double[] y, double[,] z)
        {
            Name = name;
            XName = xName;
            YName = yName;
            ZName = zName;
            XSuffix = xSuffix;
            YSuffix = ySuffix;
            ZSuffix = zSuffix;
            X = x;
            Y = y;
            Z = z;
        }
        // initializa with values
        public TEptData3(double[] x, double[] y, double[,] z)
            : this("Untitled", "X Label", "Y Label", "Z Label",
                  "", "", "",
                  x, y, z)
        { }
    }

    [Serializable]
    internal struct TEptData2 : ITEptData2
    {
        public string Name { get; }
        public string XName { get; }
        public string XSuffix { get; }
        public string YName { get; }
        public string YSuffix { get; }
        public double[] X { get; }
        public double[] Y { get; }
        // full initialization
        public TEptData2(string name, string xName, string yName,
            string xSuffix, string ySuffix,
            double[] x, double[] y)
        {
            Name = name;
            XName = xName;
            YName = yName;
            XSuffix = xSuffix;
            YSuffix = ySuffix;
            X = x;
            Y = y;
        }
        // initializa with values
        public TEptData2(double[] x, double[] y)
            : this("Untitled", "X Label", "Y Label",
                  "", "",
                  x, y) { }
    }

    [Serializable]
    internal struct TEptTabular3 : ITEptTabular3
    {
        public string Name { get; }
        public string Column1Name { get; }
        public string Column1Suffix { get; }
        public string Column2Name { get; }
        public string Column2Suffix { get; }
        public string ValueName { get; }
        public string ValueSuffix { get; }
        public double[] Column1 { get; }
        public double[] Column2 { get; }
        public double[] ColumnValue { get; }
        // full initialization
        public TEptTabular3(
            string name, string col1Name, string col2Name, string valueName,
            string col1Suffix, string col2Suffix, string valueSuffix,
            double[] col1, double[] col2, double[] values)
        {
            Name = name;
            Column1Name = col1Name;
            Column2Name = col2Name;
            ValueName = valueName;
            Column1Suffix = col1Suffix;
            Column2Suffix = col2Suffix;
            ValueSuffix = valueSuffix;
            Column1 = col1;
            Column2 = col2;
            ColumnValue = values;
        }
        // initialize with values
        public TEptTabular3(double[] rows, double[] columns, double[] values)
            : this(
                  "Untitled", "Row Label", "Column Label", "Value Label",
                  "", "", "",
                  rows, columns, values) { }
    }
}
