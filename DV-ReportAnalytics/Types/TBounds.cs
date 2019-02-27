using System;

namespace DV_ReportAnalytics.Types
{
    struct TBounds : ITBounds
    {
        public int LBound { get; }
        public int UBound { get; } 

        public TBounds(int lbound, int ubound)
        {
            LBound = lbound;
            UBound = ubound;
        }

        public bool IsBoundOverlapped()
        {
            return LBound == UBound;
        }
    }
}
