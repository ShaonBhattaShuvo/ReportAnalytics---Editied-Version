using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    [Serializable]
    internal class TData3<TX, TY, TZ> : ITData3<TX, TY, TZ>
    {
        public TX[] X { get; }
        public TY[] Y { get; }
        public TZ[,] Z { get; }

        public TData3(TX[] x, TY[] y, TZ[,] z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    [Serializable]
    internal class TData2<TX, TY> : ITData2<TX, TY>
    {
        public TX[] X { get; }
        public TY[] Y { get; }

        public TData2(TX[] x, TY[] y)
        {
            X = x;
            Y = y;
        }
    }

    [Serializable]
    internal class TData3Dictionary<TX, TY, TZ> : Dictionary<string, TData3<TX, TY, TZ>> { }

    [Serializable]
    internal class TData2Dictionary<TX, TY> : Dictionary<string, TData2<TX, TY>> { }
}
