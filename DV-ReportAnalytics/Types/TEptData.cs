using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Algorithms;

namespace DV_ReportAnalytics.Types
{
    struct TEptData : ITEptData
    {
        // interpolated values
        public List<double> XI { private set; get; }
        public List<double> YI { private set; get; }
        public List<List<double>> ZI { private set; get; }
        // original values
        public List<double> X { get; }
        public List<double> Y { get; }
        public List<List<double>> Z { get; }

        public TEptData(List<double> x, List<double> y, List<List<double>> z)
        {
            XI = X = x;
            YI = Y = y;
            ZI = Z = z;
        }

        // interpolation
        public void Interpolate (int xInterp, int yInterp)
        {
            XI = Interpolation.ExtendArray(X, xInterp);
            YI = Interpolation.ExtendArray(Y, yInterp);
            List<List<double>> interped = new List<List<double>>();
            // destination points
            double dstX;
            double dstY;
            for (int i = 0; i < YI.Count; i++)
            {
                List<double> row = new List<double>();
                dstY = YI[i];
                for (int j = 0; j < XI.Count; j++)
                {
                    dstX = XI[j];
                    row.Add(Interpolation.BilinearInterpolation(Z, X, Y, dstX, dstY));
                }
                interped.Add(row);
            }
            ZI = interped;
        }
    }
}
