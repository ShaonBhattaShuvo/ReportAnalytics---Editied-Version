using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface IEptTable : ILookupTable<double, double, double>
    {
        // get interpolated by range
        TData3<double, double, double> GetData(double[] rowRange, double[] columnRange, int rowInterp, int columnInterp);

        //get all interpolated
        TData3<double, double, double> GetData(int rowInterp, int columnInterp);

        // get data by range
        TTabular3<double, double, double> GetTabular(double[] rowRange, double[] columnRange);

        // get all data
        TTabular3<double, double, double> GetTabular();

        // get interpolated by range
        TTabular3<double, double, double> GetTabular(double[] rowRange, double[] columnRange, int rowInterp, int columnInterp);

        //get all interpolated
        TTabular3<double, double, double> GetTabular(int rowInterp, int columnInterp);
    }
}
