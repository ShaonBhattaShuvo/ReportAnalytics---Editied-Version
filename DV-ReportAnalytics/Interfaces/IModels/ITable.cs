using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Table;

namespace DV_ReportAnalytics.Models
{
    // TKey: row and column, TElement: value
    interface ITable<TKey, TElement>
    {
        void SetValue(TKey row, TKey column, TElement value);
        void SetTable(TTable<TKey, TElement> table);
        void SetName(string name);
        void Transpose();
        string GetName();
        TElement GetValue(TKey row, TKey column);
        TTable<TKey, TElement> GetValueByRows(TKey[] rows);
        TTable<TKey, TElement> GetValueByColumns(TKey[] columns);
        TTable<TKey, TElement> GetTable();
        TDimension GetDimension();
    }
}
