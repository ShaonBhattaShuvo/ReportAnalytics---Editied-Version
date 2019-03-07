using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Algorithms
{
    static class Interpolation
    {
        private static TBounds _GetNeighborIndices(double[] srcArray, double value)
        {
            int lbound = 0; // lower bound of x
            int ubound = srcArray.Length - 1; // upper bound of x
            int mid = 0;
            if (srcArray[lbound] > value)
                ubound = lbound;
            else if (srcArray[ubound] < value)
                lbound = ubound;
            else
            {
                while (Math.Abs(ubound - lbound) > 1)
                {
                    mid = (int)Math.Round((double)((lbound + ubound) / 2));
                    if (srcArray[mid] < value)
                        lbound = mid;
                    else if (srcArray[mid] > value)
                        ubound = mid;
                    else if (srcArray[mid] == value)
                    {
                        lbound = mid;
                        ubound = mid;
                    }
                    else
                        break;
                }
            }
            return new TBounds(lbound, ubound);
        }

        public static double[] ExtendArray(double[] srcArray, int points)
        {
            if (points < 1)
                return srcArray;
            else
            {
                int srcLength = srcArray.Length;
                int offset = points + 1;
                double[] extended = new double[srcLength + (srcLength - 1) * points];
                for (int i = 0; i < srcLength - 1; i++)
                {
                    int baseIndex = i * offset;
                    double interValue = (srcArray[i + 1] - srcArray[i]) / offset;
                    double baseValue = srcArray[i];
                    for (int j = 0; j <= points; j++)
                        extended[baseIndex + j] = baseValue + interValue * j;
                }
                // last element
                extended[extended.Length - 1] = srcArray[srcLength - 1]; 

                return extended;
            }
        }

        public static double LinearInterpolation(double[] srcArray, double xVal)
        {
            TBounds bound = _GetNeighborIndices(srcArray, xVal);
            double ylbound = srcArray[bound.LBound];
            double yubound = srcArray[bound.UBound];
            // interpolation
            double interp = ylbound + (xVal - bound.LBound) * (yubound - ylbound) / (bound.UBound - bound.LBound);
            return interp;
        }

        public static double BilinearInterpolation(double[,] srcTable, double[] srcXAxis, double[] srcYAxis, double dstX, double dstY)
        {
            TBounds xbound = _GetNeighborIndices(srcXAxis, dstX);
            TBounds ybound = _GetNeighborIndices(srcYAxis, dstY);
            double q11 = srcTable[ybound.LBound, xbound.LBound];
            double q21 = srcTable[ybound.UBound, xbound.LBound];
            double q12 = srcTable[ybound.LBound, xbound.UBound];
            double q22 = srcTable[ybound.UBound, xbound.UBound];
            double x1 = srcXAxis[xbound.LBound];
            double x2 = srcXAxis[xbound.UBound];
            double y1 = srcYAxis[ybound.LBound];
            double y2 = srcYAxis[ybound.UBound];
            double interp;

            // if point exactly found on a node do not interpolate
            if (xbound.Overlapped && ybound.Overlapped)
                interp = q11;
            // if point lies exactly on an xAxis node do linear interpolation
            else if (xbound.Overlapped)
                interp = q11 + (q22 - q11) * (dstY - y1) / (y2 - y1);
            // if point lies exactly on an yAxis node do liear interpolation
            else if (ybound.Overlapped)
                interp = q11 + (q12 - q11) * (dstX - x1) / (x2 - x1);
            else
                interp = (q11 * (y2 - dstY) * (x2 - dstX) + 
                    q21 * (dstY - y1) * (x2 - dstX) + 
                    q12 * (y2 - dstY) * (dstX - x1) + 
                    q22 * (dstY - y1) * (dstX - x1)) / ((y2 - y1) * (x2 - x1));

            return interp;
        }

        public static void TableBilinearInterpolation(double[] xi, double[] yi, double[,] zi, int xInterp, int yInterp, out double[] xo, out double[] yo, out double[,] zo)
        {
            xo = ExtendArray(xi, xInterp);
            yo = ExtendArray(yi, yInterp);
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
                    zo[r, c] = BilinearInterpolation(zi, xi, yi, dstX, dstY);
                }
            }
        }
    }
}
