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

        }

        public V GetValue(KR row, KC column)
        {

        }

        public TTable<KR, KC, V> GetValueByRows(KR[] rows)
        {

        }

        public TTable<KR, KC, V> GetValueByColumns(KC[] columns)
        {

        }

        public TTable<KR, KC, V> GetTable()
        {

        }

        public TDimension GetDimension()
        {

        }
    }
}
