using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITBounds
    {
        // lower and upper bounds
        int LBound { get; }
        int UBound { get; }
        // check if bounds are overlapped
        bool Overlapped { get; }
    }
}
