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
        static private int LinearInterp(int[] srcArray, int xVal)
        {
            

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
    }
}
