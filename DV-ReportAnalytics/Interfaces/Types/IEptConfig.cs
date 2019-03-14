using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    internal interface IEptConfig
    {
        Dictionary<string, bool> Tables { get; }
        int SpeedInterp { get; }
        int TorqueInterp { get; }
    }
}
