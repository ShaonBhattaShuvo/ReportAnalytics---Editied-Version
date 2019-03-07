using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Algorithms;

namespace DV_ReportAnalytics.Models
{
    class EptTable : LookupTable<double, double, double>, IEptTable
    {
        // initialize all properties
        public EptTable(
            string name, string rowName, string columnName, string valueName, 
            string rowSuffix, string columnSuffix, string valueSuffix,
            double[] rows, double[] columns, double[,] values)
            : base(
                  name, rowName, columnName, valueName,
                  rowSuffix, columnSuffix, valueSuffix,
                  rows, columns, values) { }

        // default constructor
        public EptTable() : base() { }

        // interpolation
        protected void _Interpolate (double[] xi, double[] yi, double[,] zi, int xInterp, int yInterp, out double[] xo, out double[] yo, out double[,] zo)
        {
            xo = Interpolation.ExtendArray(xi, xInterp);
            yo = Interpolation.ExtendArray(yi, yInterp);
            zo = new double[yo.Length, xo.Length];
            // destination points
            double dstX;
            double dstY;
            for (int r = 0; r < yo.Length; r++)
            {
                dstY = yo[r];
                for (int c = 0; c < xo.Length; c++)
                {
                    dstX = xo[c];
                    zo[r, c] = Interpolation.BilinearInterpolation(zi, xi, yi, dstX, dstY);
                }
            }
        }

        // overload base method for interpolation
        public TData3<double, double, double> GetData(int columnInterp, int rowInterp, double[] columnRange = null, double[] rowRange = null)
        {
            // retrive original data
            _GetXYZ(columnRange, rowRange, out double[] x, out double[] y, out double[,] z);
            _Interpolate(x, y, z, columnInterp, rowInterp, out double[] xo, out double[] yo, out double[,] zo);
            TData3<double, double, double> data =
                new TData3<double, double, double>(
                    Name, KeyColumnName, KeyRowName, ValueName, 
                    KeyColumnSuffix, KeyColumnSuffix, ValueSuffix, 
                    xo, yo, zo);
            return data;
        }
    }
}
