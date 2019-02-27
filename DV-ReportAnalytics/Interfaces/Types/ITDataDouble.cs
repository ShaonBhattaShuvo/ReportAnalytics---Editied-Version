using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    interface ITData3DDouble : ITData3D<double, double, double>
    {
        // interpolated values
        List<double> XI { get; }
        List<double> YI { get; }
        List<List<double>> ZI { get; }
        // do interpolation
        void Interpolate(int xInterp, int yInterp);
    }
}
