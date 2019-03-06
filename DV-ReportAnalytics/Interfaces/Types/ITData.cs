using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    interface ITData3<TX, TY, TZ>
    {
        List<TX> X { get; }
        List<TY> Y { get; }
        List<List<TZ>> Z { get; }
    }

    interface ITData2<TX, TY>
    {
        List<TX> X { get; }
        List<TY> Y { get; }
    }
}
