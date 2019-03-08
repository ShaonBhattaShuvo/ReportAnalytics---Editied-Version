using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Algorithms;

namespace DV_ReportAnalytics.Types
{
    [Obsolete("This struc is no longer in use. Use the corresponded class to get interpolation instead.", false)]
    internal struct TEptData : ITEptData
    {
        public string Name { get; }
        public string XName { get; }
        public string XSuffix { get; }
        public string YName { get; }
        public string YSuffix { get; }
        public string ZName { get; }
        public string ZSuffix { get; }
        // interpolated values
        public double[] XI { private set; get; }
        public double[] YI { private set; get; }
        public double[,] ZI { private set; get; }
        // original values
        public double[] X { get; }
        public double[] Y { get; }
        public double[,] Z { get; }

        public TEptData(string name, string xName, string yName, string zName,
            string xSuffix, string ySuffix, string zSuffix,
            double[] x, double[] y, double[,] z)
        {
            XI = X = x;
            YI = Y = y;
            ZI = Z = z;
            Name = name;
            XName = xName;
            YName = yName;
            ZName = zName;
            XSuffix = xSuffix;
            YSuffix = ySuffix;
            ZSuffix = zSuffix;
        }

        // interpolation
        public void Interpolate (int xInterp, int yInterp)
        {
            XI = Interpolation.ExtendArray(X, xInterp);
            YI = Interpolation.ExtendArray(Y, yInterp);
            ZI = new double[YI.Length, XI.Length];
            // destination points
            double dstX;
            double dstY;
            for (int i = 0; i < YI.Length; i++)
            {
                dstY = YI[i];
                for (int j = 0; j < XI.Length; j++)
                {
                    dstX = XI[j];
                    ZI[i, j] = Interpolation.BilinearInterpolation(Y, X, Z, dstX, dstY);
                }
            }
        }
    }
}
