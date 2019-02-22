using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    struct TData3D<TX, TY, TZ>
    {
        public List<TX> X { get; }
        public List<TY> Y { get; }
        public List<List<TZ>> Z { get; } // multi-dimensional array
        public TData3D(List<TX> x, List<TY> y, List<List<TZ>> z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    struct TData2D<TX, TY>
    {
        public List<TX> X { get; }
        public List<TY> Y { get; }
        public TData2D(List<TX> x, List<TY> y)
        {
            X = x;
            Y = y;
        }
    }

    class TData3DMap<TX, TY, TZ> : Dictionary<string, TData3D<TX, TY, TZ>> { }
    class TData2DMap<TX, TY> : Dictionary<string, TData2D<TX, TY>> { }
}
