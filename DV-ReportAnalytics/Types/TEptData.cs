using System;

namespace DV_ReportAnalytics.Types
{
    [Serializable]
    internal class TEptData3 : ITEptData3
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
    internal class TEptData2 : ITEptData2
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
}
