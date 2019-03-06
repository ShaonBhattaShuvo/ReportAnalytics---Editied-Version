using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    interface ITEptData : ITData3<double, double, double>
    {
        // interpolated values
        List<double> XI { get; }
        List<double> YI { get; }
        List<List<double>> ZI { get; }
        // do interpolation
        void Interpolate(int xInterp, int yInterp);
    }
}
