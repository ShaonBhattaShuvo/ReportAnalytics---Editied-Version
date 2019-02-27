using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    interface ITData3D<TX, TY, TZ>
    {
        List<TX> X { get; }
        List<TY> Y { get; }
        List<List<TZ>> Z { get; }
    }

    interface ITData2D<TX, TY>
    {
        List<TX> X { get; }
        List<TY> Y { get; }
    }
}
