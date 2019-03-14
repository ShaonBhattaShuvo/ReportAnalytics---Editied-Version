using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    internal struct TEptConfig : IEptConfig
    {
        public Dictionary<string, bool> Tables { get; }
        public int SpeedInterp { get; }
        public int TorqueInterp { get; }

        public TEptConfig(
            Dictionary<string, bool> tables,
            int speedInterp,
            int torqueInterp)
        {
            // create a new instance
            Tables = new Dictionary<string, bool>(tables);
            SpeedInterp = speedInterp;
            TorqueInterp = torqueInterp;
        }
    }
}
