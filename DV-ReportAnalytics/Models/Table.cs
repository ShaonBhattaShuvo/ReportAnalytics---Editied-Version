using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Table;

namespace DV_ReportAnalytics.Models
{
    class Table<KR, KC, V>: ITable<KR, KC, V>
    {
        protected TTable<KR, KC, V> _table;
        protected string _name;

        Table(string name)
        {
            _name = name;
            _table = new TTable<KR, KC, V>();
        }

        Table(): this("untitled"){} // default constructor

        public void SetValue(KR row, KC column, V value)
        {
            if (!_table.ContainsKey(row))
                _table.Add(row, new Dictionary<KC, V>()); // if the row does exist, create it
            _table[row].Add(column, value);

        }

        public void SetTable(TTable<KR, KC, V> table)
        {
            _table = table;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void Transpose()
        {

        }

        public string GetName()
        {
            return _name;
        }

        public V GetValue(KR row, KC column)
        {
            return _table[row][column];
        }

        public TTable<KR, KC, V> GetValueByRows(KR[] rows)
        {

        }

        public TTable<KR, KC, V> GetValueByColumns(KC[] columns)
        {

        }

        public TTable<KR, KC, V> GetTable()
        {
            return _table;
        }

        public TDimension GetDimension()
        {
            int rows = 0;
            int columns = 0;
            // check if the table is empty
            if (_table.Count > 0)
            {
                rows = _table.Count;
                foreach (KeyValuePair<KR, Dictionary<KC, V>> kvp in _table)
                {
                    columns = kvp.Value.Count;
                    break;
                }
            }
            return new TDimension(rows, columns);
        }
    }
}
