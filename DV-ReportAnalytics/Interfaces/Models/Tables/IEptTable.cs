using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface IEptTable : ILookupTable<double, double, double>
    {
        // get interpolated by range
        TData3<double, double, double> GetData(int columnInterp, int rowInterp, double[] columnRange, double[] rowRange);

        //get all interpolated
        TData3<double, double, double> GetData(int columnInterp, int rowInterp);

        // get data by range
        TTabular3<double, double, double> GetTabular(double[] columnRange, double[] rowRange);

        // get all data
        TTabular3<double, double, double> GetTabular();

        // get interpolated by range
        TTabular3<double, double, double> GetTabular(int columnInterp, int rowInterp, double[] columnRange, double[] rowRange);

        //get all interpolated
        TTabular3<double, double, double> GetTabular(int columnInterp, int rowInterp);
    }
}
