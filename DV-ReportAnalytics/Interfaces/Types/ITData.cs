using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    interface ITData3<TX, TY, TZ>
    {
        string Name { get; }
        string XName { get; }
        string XSuffix { get; }
        string YName { get; }
        string YSuffix { get; }
        string ZName { get; }
        string ZSuffix { get; }
        List<TX> X { get; }
        List<TY> Y { get; }
        List<List<TZ>> Z { get; }
    }

    interface ITData2<TX, TY>
    {
        string Name { get; }
        string XName { get; }
        string XSuffix { get; }
        string YName { get; }
        string YSuffix { get; }
        List<TX> X { get; }
        List<TY> Y { get; }
    }
}
