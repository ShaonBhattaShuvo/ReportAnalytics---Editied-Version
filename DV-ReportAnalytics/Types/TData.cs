using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    struct TData3<TX, TY, TZ> : ITData3<TX, TY, TZ>
    {
        public List<TX> X { get; }
        public List<TY> Y { get; }
        public List<List<TZ>> Z { get; }
        public TData3(List<TX> x, List<TY> y, List<List<TZ>> z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    struct TData2<TX, TY> : ITData2<TX, TY>
    {
        public List<TX> X { get; }
        public List<TY> Y { get; }
        public TData2(List<TX> x, List<TY> y)
        {
            X = x;
            Y = y;
        }
    }

    class TData3Map<TX, TY, TZ> : Dictionary<string, TData3<TX, TY, TZ>> { }
    class TData2Map<TX, TY> : Dictionary<string, TData2<TX, TY>> { }
}
