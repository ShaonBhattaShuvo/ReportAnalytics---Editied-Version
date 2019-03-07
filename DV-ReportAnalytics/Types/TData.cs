using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    internal struct TData3<TX, TY, TZ> : ITData3<TX, TY, TZ>
    {
        public string Name { get; }
        public string XName { get; }
        public string XSuffix { get; }
        public string YName { get; }
        public string YSuffix { get; }
        public string ZName { get; }
        public string ZSuffix { get; }
        public TX[] X { get; }
        public TY[] Y { get; }
        public TZ[,] Z { get; }
        // full initialization
        public TData3(string name, string xName, string yName, string zName, 
            string xSuffix, string ySuffix, string zSuffix,
            TX[] x, TY[] y, TZ[,] z)
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
        public TData3(TX[] x, TY[] y, TZ[,] z)
            : this("Untitled", "X Label", "Y Label", "Z Label",
                  "", "", "",
                  x, y, z) { }
    }

    struct TData2<TX, TY> : ITData2<TX, TY>
    {
        public string Name { get; }
        public string XName { get; }
        public string XSuffix { get; }
        public string YName { get; }
        public string YSuffix { get; }
        public TX[] X { get; }
        public TY[] Y { get; }
        // full initialization
        public TData2(string name, string xName, string yName,
            string xSuffix, string ySuffix,
            TX[] x, TY[] y)
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
        public TData2(TX[] x, TY[] y)
            : this("Untitled", "X Label", "Y Label",
                  "", "",
                  x, y) { }
    }

    class TData3Dictionary<TX, TY, TZ> : Dictionary<string, TData3<TX, TY, TZ>> { }
    class TData2Dictionary<TX, TY> : Dictionary<string, TData2<TX, TY>> { }
}
