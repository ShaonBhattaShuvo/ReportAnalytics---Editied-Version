using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Table;

namespace DV_ReportAnalytics.Models
{
    // KR: key row, KC: key columnm, V: value
    interface ITable<K, V>
    {
        void SetValue(K row, K column, V value);
        void SetTable(TTable<K, V> table);
        void SetName(string name);
        void Transpose();
        string GetName();
        V GetValue(K row, K column);
        TTable<K, V> GetValueByRows(K[] rows);
        TTable<K, V> GetValueByColumns(K[] columns);
        TTable<K, V> GetTable();
        TDimension GetDimension();
    }
}
