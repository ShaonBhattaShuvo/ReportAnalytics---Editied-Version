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
                    KeyColumnSuffix, KeyRowSuffix, ValueSuffix,
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

        // retrive values by map index to each other
        protected void _FlatenXYZ(double[] xi, double[] yi, double[,] zi, out double[] x, out double[] y, out double[] z)
        {
            // get xyz
            x = new double[zi.Length];
            y = new double[zi.Length];
            z = new double[zi.Length];
            // scan by row then by column
            for (int r = 0; r < yi.Length; r++)
                for (int c = 0; c < xi.Length; c++)
                {
                    x[r * xi.Length + c] = xi[c];
                    y[r * xi.Length + c] = yi[r];
                    z[r * xi.Length + c] = zi[r, c];
                }
        }

        // add info to Tabular struct
        // for internal use
        protected TTabular3<double, double, double> _GetTabular(double[] x, double[] y, double[] z)
        {
            return new TTabular3<double, double, double>(
                    Name, KeyRowName, KeyColumnName, ValueName,
                    KeyRowSuffix, KeyColumnSuffix, ValueSuffix,
                    y, x, z);
        }

        // get data by range
        public TTabular3<double, double, double> GetTabular(double[] columnRange, double[] rowRange)
        {
            _GetXYZ(rowRange, columnRange, out double[] xtemp, out double[] ytemp, out double[,] ztemp);
            _FlatenXYZ(xtemp, ytemp, ztemp, out double[] x, out double[] y, out double[] z);
            return _GetTabular(x, y, z);
        }

        // get all data
        public TTabular3<double, double, double> GetTabular()
        {
            return GetTabular(null, null);
        }

        // get interpolated by range
        public TTabular3<double, double, double> GetTabular(int columnInterp, int rowInterp, double[] columnRange, double[] rowRange)
        {
            _GetXYZ(columnRange, rowRange, out double[] xtemp, out double[] ytemp, out double[,] ztemp);
            _Interpolate(xtemp, ytemp, ztemp, columnInterp, rowInterp, out double[] xinterp, out double[] yinterp, out double[,] zinterp);
            _FlatenXYZ(xinterp, yinterp, zinterp, out double[] x, out double[] y, out double[] z);
            return _GetTabular(x, y, z);
        }

        //get all interpolated
        public TTabular3<double, double, double> GetTabular(int columnInterp, int rowInterp)
        {
            return GetTabular(columnInterp, rowInterp, null, null);
        }
    }
}
