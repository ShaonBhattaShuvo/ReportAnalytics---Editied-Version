﻿using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITData3<TX, TY, TZ>
    {
        string Name { get; }
        string XName { get; }
        string XSuffix { get; }
        string YName { get; }
        string YSuffix { get; }
        string ZName { get; }
        string ZSuffix { get; }
        TX[] X { get; }
        TY[] Y { get; }
        TZ[,] Z { get; }
    }

    internal interface ITData2<TX, TY>
    {
        string Name { get; }
        string XName { get; }
        string XSuffix { get; }
        string YName { get; }
        string YSuffix { get; }
        TX[] X { get; }
        TY[] Y { get; }
    }
}
