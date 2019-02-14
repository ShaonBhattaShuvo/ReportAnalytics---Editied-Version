using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Interpolation;

namespace DV_ReportAnalytics.Algorithms
{
    static class Interpolation
    {
        static private TBounds GetNeighborIndices(List<double> srcArray, double value)
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
                    mid = (int) Math.Round((double)((lbound + ubound) / 2));
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

        static private List<double> ExtendArray (List<double> srcArray, int points)
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

        static private double LinearInterpolation(List<double> srcArray, double xVal)
        {
            TBounds bound = GetNeighborIndices(srcArray, xVal);
            double ylbound = srcArray[bound.lbound];
            double yubound = srcArray[bound.ubound];
            // interpolation
            double interp = ylbound + (xVal - bound.lbound) * (yubound - ylbound) / (bound.ubound - bound.lbound);
            return interp;
        }

        static private double BilinearInterpolation(List<double> srcXAxis, List<double> srcYAxis, List<List<double>> srcTable, double dstX, double dstY)
        {
            TBounds xbound = GetNeighborIndices(srcXAxis, dstX);
            TBounds ybound = GetNeighborIndices(srcYAxis, dstY);
            double q11 = srcTable[ybound.lbound][xbound.lbound];
            double q21 = srcTable[ybound.ubound][xbound.lbound];
            double q12 = srcTable[ybound.lbound][xbound.ubound];
            double q22 = srcTable[ybound.ubound][xbound.ubound];
            double x1 = srcXAxis[xbound.lbound];
            double x2 = srcXAxis[xbound.ubound];
            double y1 = srcYAxis[ybound.lbound];
            double y2 = srcYAxis[ybound.ubound];

            // if point exactly found on a node do not interpolate
            if (xbound.IsBoundOverlapped() && ybound.IsBoundOverlapped())
                return q11;
            // if point lies exactly on an xAxis node do linear interpolation
            else if (xbound.IsBoundOverlapped())
                return q11 + (q22 - q11) * (dstY - y1) / (y2 - y1);
            // if point lies exactly on an yAxis node do liear interpolation
            else if (ybound.IsBoundOverlapped())
                return q11 + (q12 - q11) * (dstX - x1) / (x2 - x1);

            double interp =
                (q11 * (y2 - dstY) * (x2 - dstX) +
                q21 * (dstY - y1) * (x2 - dstX) +
                q12 * (y2 - dstY) * (dstX - x1) +
                q22 * (dstY - y1) * (dstX - x1)) /
                ((y2 - y1) * (x2 - x1));
            return interp;
        }
    }
}
