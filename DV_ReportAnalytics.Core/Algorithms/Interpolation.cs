using System;

namespace DV_ReportAnalytics.Core
{
    internal static class Interpolation
    {
        #region General double precision methods
        private static TBounds GetNeighborIndices(double[] srcArray, double value)
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
            TBounds bound = GetNeighborIndices(srcArray, xVal);
            double ylbound = srcArray[bound.LBound];
            double yubound = srcArray[bound.UBound];
            // interpolation
            double interp = ylbound + (xVal - bound.LBound) * (yubound - ylbound) / (bound.UBound - bound.LBound);
            return interp;
        }

        // dimensions should be checked before using this interpolation
        public static double BilinearInterpolation(double[] srcXAxis, double[] srcYAxis, double[,] srcTable, double dstX, double dstY)
        {
            TBounds xbound = GetNeighborIndices(srcXAxis, dstX);
            TBounds ybound = GetNeighborIndices(srcYAxis, dstY);
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
        #endregion

        public struct TBounds
        {
            public int LBound { get; }
            public int UBound { get; }
            public bool Overlapped { get; }

            public TBounds(int lbound, int ubound)
            {
                LBound = lbound;
                UBound = ubound;
                Overlapped = lbound == ubound ? true : false;
            }
        }

    }
}
