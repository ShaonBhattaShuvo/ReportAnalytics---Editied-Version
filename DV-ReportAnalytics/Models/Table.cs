using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Table;

namespace DV_ReportAnalytics.Models
{
    class Table<K, V>: ITable<K, V>
    {
        protected TTable<K, V> _table;
        protected string _name;

        Table(string name)
        {
            _name = name;
            _table = new TTable<K, V>();
        }

        Table(): this("untitled"){} // default constructor

        public void SetValue(K row, K column, V value)
        {
            if (!_table.ContainsKey(row))
                _table.Add(row, new Dictionary<K, V>()); // if the row does exist, create it
            _table[row].Add(column, value);

        }

        public void SetTable(TTable<K, V> table)
        {
            _table = table;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void Transpose()
        {
            TTable<K, V> newTable = new TTable<K, V>();
            foreach (KeyValuePair<K, Dictionary<K, V>> row in _table)
            {
                foreach (KeyValuePair<K, V> item in row.Value)
                {
                    // if the item does not exist, create it
                    // transpose row and column
                    if (!newTable.ContainsKey(item.Key))
                        newTable.Add(item.Key, new Dictionary<K, V>());
                    newTable[item.Key].Add(row.Key, item.Value);
                }
            }

        }

        public string GetName()
        {
            return _name;
        }

        public V GetValue(K row, K column)
        {
            return _table[row][column];
        }

        public TTable<K, V> GetValueByRows(K[] qrows)
        {
            TTable<K, V> query = new TTable<K, V>();
            query = _table.Where(row => qrows.Contains(row.Key)) // query by rows
                .ToTTable(row => row.Key, row => row.Value);
            return query;
        }

        public TTable<K, V> GetValueByColumns(K[] qcolumns)
        {
            TTable<K, V> query = new TTable<K, V>();
            query = _table.Select(row => new KeyValuePair<K, Dictionary<K, V>>(
                    row.Key,
                    row.Value.Where(column => qcolumns.Contains(column.Key)) // query by columns
                    .ToDictionary(column => column.Key, column => column.Value)))
                .ToTTable(row => row.Key, row => row.Value);
            return query;
        }

        public TTable<K, V> GetTable()
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
                foreach (KeyValuePair<K, Dictionary<K, V>> kvp in _table)
                {
                    columns = kvp.Value.Count;
                    break;
                }
            }
            return new TDimension(rows, columns);
        }
    }
}
