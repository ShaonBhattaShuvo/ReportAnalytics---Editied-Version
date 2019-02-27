using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface IEptTable : ILookupTable<double, double, double>
    {
        string KeyRowName { set; get; }
        string KeyColumnName { set; get; }
        string ValueName { set; get; }
        string KeyRowSuffix { set; get; }
        string KeyColumnSuffix { set; get; }
        string ValueSuffix { set; get; }
        // do interpolation
        TData3D<double, double, double> GetData3DInterpolated(int rowInterp, int columnInterp, double[] rowRange, double[] columnRange);
        TData3D<double, double, double> GetData3DInterpolatedTransposed(int rowInterp, int columnInterp, double[] rowRange, double[] columnRange);
    }
}
