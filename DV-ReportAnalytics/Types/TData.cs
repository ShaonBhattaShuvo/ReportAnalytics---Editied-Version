using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types.Data
{
    struct TData3D<TX, TY, TZ>
    {
        public List<TX> x;
        public List<TY> y;
        public List<List<TZ>> z; // multi-dimensional array
        TData3D(List<TX> x, List<TY> y, List<List<TZ>> z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    struct TData2D<TX, TY>
    {
        public List<TX> x;
        public List<TY> y;
        TData2D(List<TX> x, List<TY> y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class TData3DMap<TX, TY, TZ> : Dictionary<string, TData3D<TX, TY, TZ>> { }
    class TData2DMap<TX, TY> : Dictionary<string, TData2D<TX, TY>> { }
}
