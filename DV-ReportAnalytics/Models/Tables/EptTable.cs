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
        // override base method to add more info
        protected override TData3<double, double, double> _GetData(double[] x, double[] y, double[,] z)
        {
            return new TData3<double, double, double>(
                    Name, KeyColumnName, KeyRowName, ValueName,
                    KeyColumnSuffix, KeyColumnSuffix, ValueSuffix,
                    x, y, z);
        }

        // get interpolated by range
        public TData3<double, double, double> GetData(int columnInterp, int rowInterp, double[] columnRange, double[] rowRange)
        {
            // retrive original data
            _GetXYZ(columnRange, rowRange, out double[] x, out double[] y, out double[,] z);
            _Interpolate(x, y, z, columnInterp, rowInterp, out double[] xo, out double[] yo, out double[,] zo);
            return _GetData(xo, yo, zo);
        }

        //get all interpolated
        public TData3<double, double, double> GetData(int columnInterp, int rowInterp)
        {
            return GetData(columnInterp, rowInterp, null, null);
        }


    }
}
