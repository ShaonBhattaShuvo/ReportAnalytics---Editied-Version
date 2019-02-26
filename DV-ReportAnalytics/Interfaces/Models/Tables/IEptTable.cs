using System;

namespace DV_ReportAnalytics.Models
{
    interface IEptTable<TKeyRow, TKeyColumn, TValue> : ILookupTable<TKeyRow, TKeyColumn, TValue>
    {
        string KeyRowName { set; get; }
        string KeyColumnName { set; get; }
        string ValueName { set; get; }
        string KeyRowSuffix { set; get; }
        string KeyColumnSuffix { set; get; }
        string ValueSuffix { set; get; }
    }
}
