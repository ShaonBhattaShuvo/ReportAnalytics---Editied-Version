using System;

namespace DV_ReportAnalytics.Types
{
    struct TBounds : ITBounds
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
