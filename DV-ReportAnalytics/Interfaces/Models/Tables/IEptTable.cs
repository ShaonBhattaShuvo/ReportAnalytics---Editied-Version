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
        TData3<double, double, double> GetData(int columnInterp, int rowInterp, double[] columnRange, double[] rowRange);
    }
}
