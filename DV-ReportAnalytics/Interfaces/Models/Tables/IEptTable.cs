using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface IEptTable : ILookupTable<double, double, double>
    {
        TData3<double, double, double> GetData(int columnInterp, int rowInterp, double[] columnRange, double[] rowRange);
        TTabular3<double, double, double> GetTabular(int columnInterp, int rowInterp, double[] columnRange, double[] rowRange);
    }
}
