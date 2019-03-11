﻿using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITEptData3 : ITData3<double, double, double>
    {
        string Name { get; }
        string XName { get; }
        string XSuffix { get; }
        string YName { get; }
        string YSuffix { get; }
        string ZName { get; }
        string ZSuffix { get; }
    }

    internal interface ITEptData2 : ITData2<double, double>
    {
        string Name { get; }
        string XName { get; }
        string XSuffix { get; }
        string YName { get; }
        string YSuffix { get; }
    }
}
