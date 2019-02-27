using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Types
{
    interface ITBounds
    {
        // lower and upper bounds
        int LBound { get; }
        int UBound { get; }
        // check bounds are overlapped
        bool IsBoundOverlapped();
    }
}
