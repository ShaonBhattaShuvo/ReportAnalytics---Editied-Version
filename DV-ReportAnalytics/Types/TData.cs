using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types.Data
{
    struct TData3D
    {
        public int[] x;
        public int[] y;
        public int[,] z; // multi-dimensional array
        TData3D(int[] x, int[] y, int[,] z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    struct TData2D
    {
        public int[] x;
        public int[] y;
        TData2D(int[] x, int[] y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class TData3DMap: Dictionary<string, TData3D> {}
    class TData2DMap: Dictionary<string, TData2D> {}
}
