using System;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Algorithms;

namespace DV_ReportAnalytics.Models
{
    internal class EptTable : LookupTable<double, double, double>, IEptTable
    {
        public string Name { set; get; }
        public string KeyRowName { set; get; }
        public string KeyColumnName { set; get; }
        public string ValueName { set; get; }
        public string KeyRowSuffix { set; get; }
        public string KeyColumnSuffix { set; get; }
        public string ValueSuffix { set; get; }

        // initialize all properties
        public EptTable(
            string name, string rowName, string columnName, string valueName, 
            string rowSuffix, string columnSuffix, string valueSuffix,
            double[] rows, double[] columns, double[,] values)
            : base(rows, columns, values)
        {
            Name = name;
            KeyRowName = rowName;
            KeyColumnName = columnName;
            ValueName = valueName;
            KeyRowSuffix = rowSuffix;
            KeyColumnSuffix = columnSuffix;
            ValueSuffix = valueSuffix;
        }

        // default constructor
        public EptTable() : this(
            "Untitled", "Row Label", "Column Label", "Value Label",
            "", "", "",
            new double[0], new double[0], new double[0, 0]) { }

        // ----------------------------Internal methods-------------------------------------------
        // get provided range
        protected void GetRange(double[] rowRange, double[] colRange, out double[] x, out double[] y)
        {
            // get x range
            if (colRange == null)
            {
                x = GetKeysColumns();
            }
            else
            {
                x = colRange;
                // columnRange may not be sorted
                Array.Sort(x);
            }
            // get y range
            if (rowRange == null)
            {
                y = GetKeysRows();
            }
            else
            {
                y = rowRange;
                // rowRange may not be sorted
                Array.Sort(y);
            }
        }

        // get xyz values
        protected void GetXYZ(double[] rowRange, double[] colRange, out double[] x, out double[] y, out double[,] z)
        {
            GetRange(rowRange, colRange, out x, out y);
            // get z
            z = new double[y.Length, x.Length];
            // scan by row then by column
            for (int r = 0; r < y.Length; r++)
                for (int c = 0; c < x.Length; c++)
                    z[r, c] = this[y[r], x[c]];
        }

        // retrive values by map index to each other
        protected void FlatenXYZ(double[] xi, double[] yi, double[,] zi, out double[] x, out double[] y, out double[] z)
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

        // all GetData methods get data from here
        protected TEptData3 BuildData(double[] x, double[] y, double[,] z)
        {
            return new TEptData3(
                    Name, KeyColumnName, KeyRowName, ValueName,
                    KeyColumnSuffix, KeyRowSuffix, ValueSuffix,
                    x, y, z);
        }

        // add info to Tabular struct
        // all GetTabular methods from here
        protected TEptTabular3 BuildTabular(double[] x, double[] y, double[] z)
        {
            return new TEptTabular3(
                    Name, KeyColumnName, KeyRowName, ValueName,
                    KeyColumnSuffix, KeyRowSuffix, ValueSuffix,
                    x, y, z);
        }
        
        // -----------------------Get Data Methods------------------------------------------------
        // get data by range
        public TEptData3 GetData(double[] rowRange, double[] colRange)
        {
            GetXYZ(rowRange, colRange, out double[] x, out double[] y, out double[,] z);
            return BuildData(x, y, z);
        }

        // get all data
        public TEptData3 GetData()
        {
            return GetData(null, null);
        }

        // get interpolated by range
        public TEptData3 GetData(double[] rowRange, double[] colRange, int rowInterp, int colInterp)
        {
            // retrive original data
            GetXYZ(rowRange, colRange, out double[] x, out double[] y, out double[,] z);
            Interpolation.TableBilinearInterpolation(x, y, z, colInterp, rowInterp, out double[] xo, out double[] yo, out double[,] zo);
            return BuildData(xo, yo, zo);
        }

        //get all interpolated
        public TEptData3 GetData(int rowInterp, int colInterp)
        {
            return GetData(null, null, rowInterp, colInterp);
        }

        // -----------------------Get Tabular Methods------------------------------------------------
        // get data by range
        public TEptTabular3 GetTabular(double[] rowRange, double[] colRange)
        {
            GetXYZ(rowRange, colRange, out double[] xtemp, out double[] ytemp, out double[,] ztemp);
            FlatenXYZ(xtemp, ytemp, ztemp, out double[] x, out double[] y, out double[] z);
            return BuildTabular(x, y, z);
        }

        // get all data
        public TEptTabular3 GetTabular()
        {
            return GetTabular(null, null);
        }

        // get interpolated by range
        public TEptTabular3 GetTabular(double[] rowRange, double[] colRange, int rowInterp, int colInterp)
        {
            GetXYZ(rowRange, colRange, out double[] xtemp, out double[] ytemp, out double[,] ztemp);
            Interpolation.TableBilinearInterpolation(xtemp, ytemp, ztemp, colInterp, rowInterp, out double[] xinterp, out double[] yinterp, out double[,] zinterp);
            FlatenXYZ(xinterp, yinterp, zinterp, out double[] x, out double[] y, out double[] z);
            return BuildTabular(x, y, z);
        }

        //get all interpolated
        public TEptTabular3 GetTabular(int rowInterp, int colInterp)
        {
            return GetTabular(null, null, rowInterp, colInterp);
        }
    }
}
