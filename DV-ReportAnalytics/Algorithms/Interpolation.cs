using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Algorithms
{
    static class Interpolation
    {
        static private TBounds _GetNeighborIndices(List<double> srcArray, double value)
        {
            int lbound = 0; // lower bound of x
            int ubound = srcArray.Count - 1; // upper bound of x
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

        static public List<double> ExtendArray(List<double> srcArray, int points)
        {
            if (points < 1)
                return srcArray;
            else
            {
                List<double> extended = new List<double>();
                for (int i = 0; i < srcArray.Count - 1; i++)
                {
                    extended.Add(srcArray[i]);
                    double interval = (srcArray[i + 1] - srcArray[i]) / (points + 1);
                    double insertPoint = srcArray[i];
                    for (int j = 1; j <= points; j++)
                    {
                        insertPoint = insertPoint + interval;
                        extended.Add(insertPoint);
                    }
                }
                extended.Add(srcArray[srcArray.Count - 1]); // last element
                return extended;
            }
        }

        static public double LinearInterpolation(List<double> srcArray, double xVal)
        {
            TBounds bound = _GetNeighborIndices(srcArray, xVal);
            double ylbound = srcArray[bound.LBound];
            double yubound = srcArray[bound.UBound];
            // interpolation
            double interp = ylbound + (xVal - bound.LBound) * (yubound - ylbound) / (bound.UBound - bound.LBound);
            return interp;
        }

        static public double BilinearInterpolation(List<List<double>> srcTable, List<double> srcXAxis, List<double> srcYAxis, double dstX, double dstY)
        {
            TBounds xbound = _GetNeighborIndices(srcXAxis, dstX);
            TBounds ybound = _GetNeighborIndices(srcYAxis, dstY);
            double q11 = srcTable[ybound.LBound][xbound.LBound];
            double q21 = srcTable[ybound.UBound][xbound.LBound];
            double q12 = srcTable[ybound.LBound][xbound.UBound];
            double q22 = srcTable[ybound.UBound][xbound.UBound];
            double x1 = srcXAxis[xbound.LBound];
            double x2 = srcXAxis[xbound.UBound];
            double y1 = srcYAxis[ybound.LBound];
            double y2 = srcYAxis[ybound.UBound];
            double interp;

            // if point exactly found on a node do not interpolate
            if (xbound.IsBoundOverlapped() && ybound.IsBoundOverlapped())
                interp = q11;
            // if point lies exactly on an xAxis node do linear interpolation
            else if (xbound.IsBoundOverlapped())
                interp = q11 + (q22 - q11) * (dstY - y1) / (y2 - y1);
            // if point lies exactly on an yAxis node do liear interpolation
            else if (ybound.IsBoundOverlapped())
                interp = q11 + (q12 - q11) * (dstX - x1) / (x2 - x1);
            else
                interp = (q11 * (y2 - dstY) * (x2 - dstX) + 
                    q21 * (dstY - y1) * (x2 - dstX) + 
                    q12 * (y2 - dstY) * (dstX - x1) + 
                    q22 * (dstY - y1) * (dstX - x1)) / ((y2 - y1) * (x2 - x1));

            return interp;
        }
    }
}
