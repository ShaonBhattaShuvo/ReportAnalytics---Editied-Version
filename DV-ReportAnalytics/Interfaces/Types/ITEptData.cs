using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITEptData : ITData3<double, double, double>
    {
        // interpolated values
        double[] XI { get; }
        double[] YI { get; }
        double[,] ZI { get; }
        // do interpolation
        void Interpolate(int xInterp, int yInterp);
    }
}
