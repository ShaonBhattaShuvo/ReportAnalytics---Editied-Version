using System;

namespace DV_ReportAnalytics.Types.Interpolation
{
    struct TBounds
    {
        public int lbound;
        public int ubound;
        public TBounds(int lbound, int ubound)
        {
            this.lbound = lbound;
            this.ubound = ubound;
        }
    }
}
