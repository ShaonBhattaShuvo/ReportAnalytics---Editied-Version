using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Algorithms;

namespace DV_ReportAnalytics.Models
{
    class EptTable : LookupTable<double, double, double>, IEptTable
    {
        // initialize all properties
        public EptTable(string name, string rowName, string columnName, string valueName, 
            string rowSuffix, string columnSuffix, string valueSuffix,
            double[] rows, double[] columns, double[,] values)
            : base(name, rowName, columnName, valueName,
                  rowSuffix, columnSuffix, valueSuffix,
                  rows, columns, values) { }

        // default constructor
        public EptTable() : base() { }

        // interpolation
        protected void _Interpolate (List<double> xi, List<double> yi, List<List<double>> zi, int xInterp, int yInterp, out List<double> xo, out List<double> yo, out List<List<double>> zo)
        {
            xo = Interpolation.ExtendArray(xi, xInterp);
            yo = Interpolation.ExtendArray(yi, yInterp);
            List<List<double>> interped = new List<List<double>>();
            // destination points
            double dstX;
            double dstY;
            for (int i = 0; i < yo.Count; i++)
            {
                List<double> row = new List<double>();
                dstY = yo[i];
                for (int j = 0; j < xo.Count; j++)
                {
                    dstX = xo[j];
                    row.Add(Interpolation.BilinearInterpolation(zi, xi, yi, dstX, dstY));
                }
                interped.Add(row);
            }
            zo = interped;
        }

        // overload base method for interpolation
        public TData3<double, double, double> GetData(int columnInterp, int rowInterp, double[] columnRange = null, double[] rowRange = null)
        {
            // retrive original data
            _GetXYZ(columnRange, rowRange, out List<double> x, out List<double> y, out List<List<double>> z);
            _Interpolate(x, y, z, columnInterp, rowInterp, out List<double> xo, out List<double> yo, out List<List<double>> zo);
            TData3<double, double, double> data = new TData3<double, double, double>(xo, yo, zo);
            return data;
        }
    }
}
