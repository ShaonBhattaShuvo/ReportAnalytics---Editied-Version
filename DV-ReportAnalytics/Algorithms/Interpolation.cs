using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Algorithms
{
    static class Interpolation
    {
        static public void BilinearTest()
        {
            List<double> srcX = new List<double>() { 1, 2, 3 };
            List<double> srcY = new List<double>() { 1, 2, 3 };
            List<List<double>> srcData = new List<List<double>>()
            {
                new List<double>() {0,128,0},
                new List<double>() {128,255,128},
                new List<double>() {0,128,0}
            };
            List<double> extX = new List<double>() { 1, 1.25, 1.5, 1.75, 2, 2.25, 2.5, 2.75, 3 };
            List<double> extY = new List<double>() { 1, 1.25, 1.5, 1.75, 2, 2.25, 2.5, 2.75, 3 };

            double dstX = 0;
            double dstY = 0;
            List<List<double>> result = new List<List<double>>();

            Action<List<double>> show = row => {
                row.ForEach(x => Console.Write(x + " "));
                Console.WriteLine();
            };

            for (int x = 0; x < extX.Count; x++)
            {
                List<double> row = new List<double>();
                dstX = extX[x];
                for (int y = 0; y < extY.Count; y++)
                {
                    dstY = extY[y];
                    row.Add(BilinearInterpolation(srcData, srcX, srcY, dstX, dstY));
                }
                result.Add(row);
            }
            Console.WriteLine("Source Data:");
            srcData.ForEach(show);
            Console.WriteLine("Result Data:");
            result.ForEach(show);
        }

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
            TBounds bound = GetNeighborIndices(srcArray, xVal);
            double ylbound = srcArray[bound.LBound];
            double yubound = srcArray[bound.UBound];
            // interpolation
            double interp = ylbound + (xVal - bound.LBound) * (yubound - ylbound) / (bound.UBound - bound.LBound);
            return interp;
        }

        static public double BilinearInterpolation(List<List<double>> srcTable, List<double> srcXAxis, List<double> srcYAxis, double dstX, double dstY)
        {
            TBounds xbound = GetNeighborIndices(srcXAxis, dstX);
            TBounds ybound = GetNeighborIndices(srcYAxis, dstY);
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
