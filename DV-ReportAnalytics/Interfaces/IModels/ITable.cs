using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Table;

namespace DV_ReportAnalytics.Models
{
    // KR: key row, KC: key columnm, V: value
    interface ITable<KR, KC, V>
    {
        void SetValue(KR row, KC column, V value);
        void SetTable(TTable<KR, KC, V> table);
        void SetName(string name);
        void Transpose();
        string GetName();
        V GetValue(KR row, KC column);
        TTable<KR, KC, V> GetValueByRows(KR[] rows);
        TTable<KR, KC, V> GetValueByColumns(KC[] columns);
        TTable<KR, KC, V> GetTable();
        TDimension GetDimension();
    }
}
