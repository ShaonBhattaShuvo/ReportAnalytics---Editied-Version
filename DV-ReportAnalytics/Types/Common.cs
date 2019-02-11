using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types.Data
{
    struct Data3D
    {
        int[] x;
        int[] y;
        int[,] z; // multi-dimensional array
    }

    struct Data2D
    {
        int[] x;
        int[] y;
    }

    class Data3DMap: Dictionary<string, Data3D>{}
    class Data2DMap: Dictionary<string, Data2D>{}
}
