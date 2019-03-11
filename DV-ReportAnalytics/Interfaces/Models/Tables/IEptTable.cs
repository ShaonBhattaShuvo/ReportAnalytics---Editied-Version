using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    internal interface IEptTable : 
        ILookupTable<double, double, double>, 
        ITDataProvider3<TEptData3, double, double, double>, 
        ITTabularProvider3<TEptTabular3, double, double, double>
    {
        string Name { set; get; }
        string KeyRowName { set; get; }
        string KeyColumnName { set; get; }
        string ValueName { set; get; }
        string KeyRowSuffix { set; get; }
        string KeyColumnSuffix { set; get; }
        string ValueSuffix { set; get; }

        // get interpolated by range
        TEptData3 GetData(double[] rowRange, double[] colRange, int rowInterp, int colInterp);

        //get all interpolated
        TEptData3 GetData(int rowInterp, int colInterp);

        // get interpolated by range
        TEptTabular3 GetTabular(double[] rowRange, double[] colRange, int rowInterp, int colInterp);

        //get all interpolated
        TEptTabular3 GetTabular(int rowInterp, int colInterp);
    }
}
