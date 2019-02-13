using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Types.Table;

namespace DV_ReportAnalytics.Models
{
    class Table<TKey, TElement>: ITable<TKey, TElement>
    {
        protected TTable<TKey, TElement> _table;
        protected string _name;

        Table(string name)
        {
            _name = name;
            _table = new TTable<TKey, TElement>();
        }

        Table(): this("untitled"){} // default constructor

        public void SetValue(TKey row, TKey column, TElement value)
        {
            if (!_table.ContainsKey(row))
                _table.Add(row, new Dictionary<TKey, TElement>()); // if the row does exist, create it
            _table[row].Add(column, value);

        }

        public void SetTable(TTable<TKey, TElement> table)
        {
            _table = table;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void Transpose()
        {
            TTable<TKey, TElement> newTable = new TTable<TKey, TElement>();
            foreach (KeyValuePair<TKey, Dictionary<TKey, TElement>> row in _table)
            {
                foreach (KeyValuePair<TKey, TElement> item in row.Value)
                {
                    // if the item does not exist, create it
                    // transpose row and column
                    if (!newTable.ContainsKey(item.Key))
                        newTable.Add(item.Key, new Dictionary<TKey, TElement>());
                    newTable[item.Key].Add(row.Key, item.Value);
                }
            }

        }

        public string GetName()
        {
            return _name;
        }

        public TElement GetValue(TKey row, TKey column)
        {
            return _table[row][column];
        }

        public TTable<TKey, TElement> GetValueByRows(TKey[] qrows)
        {
            TTable<TKey, TElement> query = new TTable<TKey, TElement>();
            query = _table.Where(row => qrows.Contains(row.Key)) // query by rows
                .ToTTable(row => row.Key, row => row.Value);
            return query;
        }

        public TTable<TKey, TElement> GetValueByColumns(TKey[] qcolumns)
        {
            TTable<TKey, TElement> query = new TTable<TKey, TElement>();
            query = _table.Select(row => new KeyValuePair<TKey, Dictionary<TKey, TElement>>(
                    row.Key,
                    row.Value.Where(column => qcolumns.Contains(column.Key)) // query by columns
                    .ToDictionary(column => column.Key, column => column.Value)))
                .ToTTable(row => row.Key, row => row.Value);
            return query;
        }

        public TTable<TKey, TElement> GetTable()
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
                foreach (KeyValuePair<TKey, Dictionary<TKey, TElement>> kvp in _table)
                {
                    columns = kvp.Value.Count;
                    break;
                }
            }
            return new TDimension(rows, columns);
        }
    }
}
