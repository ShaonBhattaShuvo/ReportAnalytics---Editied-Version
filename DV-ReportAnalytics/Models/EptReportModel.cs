using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Models;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Models
{
    internal sealed class EptReportModel : IEptReportModel
    {
        // ---------fields and properties-------------------------
        private Dictionary<string, EptTable> _tableDictionary;
        public event WorkbookTableUpdateEventHandler WorkbookTableUpdate;

        public string[] TableNames
        {
            get
            {
                string[] keys = new string[_tableDictionary.Keys.Count];
                _tableDictionary.Keys.CopyTo(keys, 0);
                return keys;
            }
        }

        // get specific table
        public EptTable this[string tableName]
        {
            get
            {
                return
                _tableDictionary.TryGetValue(tableName, out EptTable table) ?
                table : null;
            }
            set
            {
                // replace table
                // if not exist throw exception
                _tableDictionary[tableName] = value;
            }
        }

        // --------------constructor----------------
        public EptReportModel()
        {
            _tableDictionary = new Dictionary<string, EptTable>();
        }

        // ----------------public methods------------------
        public void Add(string name)
        {
            // throws exception if it alreay exists
            _tableDictionary.Add(name, new EptTable());
            _Update();
        }

        public void Remove(string name)
        {
            _tableDictionary.Remove(name);
            _Update();
        }

        public bool Contains(string name)
        {
            return _tableDictionary.ContainsKey(name);
        }

        public Dictionary<string, TEptData3> GetData()
        {
            return GetData(_tableDictionary.Keys.ToArray());
        }

        public Dictionary<string, TEptData3> GetData(string[] names)
        {
            Dictionary<string, TEptData3> result = new Dictionary<string, TEptData3>();
            foreach (string name in names)
            {
                if (_tableDictionary.TryGetValue(name, out EptTable table))
                {
                    result.Add(name, table.GetData());
                }
            }
   
            return result;
        }

        public Dictionary<string, TEptData3> GetData(int rowInterp, int colInterp)
        {
            return GetData(_tableDictionary.Keys.ToArray(), rowInterp, colInterp);
        }

        public Dictionary<string, TEptData3> GetData(string[] names, int rowInterp, int colInterp)
        {
            Dictionary<string, TEptData3> result = new Dictionary<string, TEptData3>();
            foreach (string name in names)
            {
                if (_tableDictionary.TryGetValue(name, out EptTable table))
                {
                    result.Add(name, table.GetData(rowInterp, colInterp));
                }
            }

            return result;
        }

        // ---------------private methods-------------------
        private void _Update()
        {
            if (WorkbookTableUpdate != null)
            {
                WorkbookTableUpdate.Invoke(this, new WorkbookTableUpdateEventArgs(_tableDictionary.Keys.ToArray()));
            }
        }

        private void _UpdateModel()
        {
            if (_range != null)
            {
                // search row by row
                for (int i = 0; i < _range.ColumnCount; i++)
                {
                    string name = (string)_range.Cells[i, SearchIndexName].Value;
                    MatchCollection matches = _searchFilter.Matches(name);
                    // if there is any match
                    if (matches.Count > 0)
                    {
                        // 0 is the table name, 1 is the row, 0 is the column
                        string tableName = matches[0].Value;
                        double row = Convert.ToDouble(matches[1].Value);
                        double column = Convert.ToDouble(matches[2].Value);
                        EptTable table;
                        // initiate non-existed table
                        if (_tableDictionary.TryGetValue(tableName, out table))
                        {
                            _tableDictionary.Add(tableName, new EptTable());
                            table = _tableDictionary[tableName];
                            table.Name = tableName;
                        }
                        // add value
                        table[row, column] = (double)_range.Cells[i, SearchIndexValue].Value;
                    }
                }
            }
            // TODO: throw exception
        }
    }
}
