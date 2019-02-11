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
        void SetTable();
        void Transpose();
        string GetName();
        V GetValue(KR row, KC column);
        Table GetValueByRows(KR[] rows);
        Table GetValueByColumns(KC[] columns);
        Table GetTable();
        Dimension GetDimension();
    }
}
