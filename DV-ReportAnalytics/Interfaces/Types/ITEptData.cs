using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    interface ITEptData : ITData3<double, double, double>
    {
        // interpolated values
        double[] XI { get; }
        double[] YI { get; }
        double[,] ZI { get; }
        // do interpolation
        void Interpolate(int xInterp, int yInterp);
    }
}
