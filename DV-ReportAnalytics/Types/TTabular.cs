using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Types
{
    [Serializable]
    internal struct TTabular3<TColumn1, TColumn2, TValue> : ITTabular3<TColumn1, TColumn2, TValue>
    {
        public TColumn1[] Column1 { get; }
        public TColumn2[] Column2 { get; }
        public TValue[] ColumnValue { get; }

        public TTabular3(TColumn1[] col1, TColumn2[] col2, TValue[] values)
        {
            Column1 = col1;
            Column2 = col2;
            ColumnValue = values;
        }
    }

    [Serializable]
    internal class TTabular3Dictionary<TColumn1, TColumn2, TValue> : Dictionary<string, TTabular3<TColumn1, TColumn2, TValue>> { }
}
