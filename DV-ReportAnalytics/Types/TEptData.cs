using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Algorithms;

namespace DV_ReportAnalytics.Types
{
    [Obsolete("This struc is no longer in use. Use the corresponded class to get interpolation instead.", false)]
    struct TEptData : ITEptData
    {
        public string Name { get; }
        public string XName { get; }
        public string XSuffix { get; }
        public string YName { get; }
        public string YSuffix { get; }
        public string ZName { get; }
        public string ZSuffix { get; }
        // interpolated values
        public List<double> XI { private set; get; }
        public List<double> YI { private set; get; }
        public List<List<double>> ZI { private set; get; }
        // original values
        public List<double> X { get; }
        public List<double> Y { get; }
        public List<List<double>> Z { get; }

        public TEptData(string name, string xName, string yName, string zName,
            string xSuffix, string ySuffix, string zSuffix,
            List<double> x, List<double> y, List<List<double>> z)
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
