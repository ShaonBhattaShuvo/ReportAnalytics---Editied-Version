using System;

namespace DV_ReportAnalytics.Types
{
    internal interface ITData { }

    internal interface ITData3<TX, TY, TZ> : ITData
    {
        TX[] X { get; }
        TY[] Y { get; }
        TZ[,] Z { get; }
    }

    internal interface ITData2<TX, TY> : ITData
    {
        TX[] X { get; }
        TY[] Y { get; }
    }

    internal interface ITDataProvider<Data>
        where Data : ITData
    {
        // get all data
        Data GetData();
    }

    internal interface ITDataProvider3<Data, TX, TY, TZ> : ITDataProvider<Data>
        where Data : ITData3<TX, TY, TZ>
    {
        // get data by range
        Data GetData(TX[] xRange, TY[] yRange);
    }

    internal interface ITDataProvider2<Data, TX, TY> : ITDataProvider<Data>
        where Data : ITData2<TX, TY>
    {
        // get data by range
        Data GetData(TX[] xRange);
    }
}
