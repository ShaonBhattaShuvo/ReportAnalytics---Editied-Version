using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Xml;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Models;
using DV_ReportAnalytics.Events;
using SpreadsheetGear;

namespace DV_ReportAnalytics.Models
{
    internal sealed class EptReportModel : IEptReportModel
    {
        // ---------fields and properties-------------------------
        private Regex _searchFilter;
        private Dictionary<string, EptTable> _tableDictionary;
        private XmlDocument _displayConfig;
        public int SearchIndexName { set; get; }
        public int SearchIndexValue { set; get; }
        public event WorkbookTableUpdateEventHandler<TEptData3> WorkbookTableUpdate;
        public IRange Range { set; get; }

        public string[] TableNames
        {
            get
            {
                string[] keys = new string[_tableDictionary.Keys.Count];
                _tableDictionary.Keys.CopyTo(keys, 0);
                return keys;
            }
        }

        public string SearchPattern {
            set
            {
                if (value == _searchFilter.ToString())
                {
                    _searchFilter = new Regex(value);
                    // TODO: update tables
                }
            }
            get
            {
                return (_searchFilter != null) ? _searchFilter.ToString() : "";
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
        }
        
        public string DisplayConfig
        {
            set
            {
                _displayConfig.LoadXml(value);
            }
            get
            {
                return _displayConfig.ToString();
            }
        }

        // --------------constructor----------------
        public EptReportModel()
        {
            
        }

        public EptReportModel(IRange range, string pattern)
        {
            Range = range;
            _searchFilter = new Regex(pattern);
        }

        // ----------------public methods------------------


        // ---------------private methods-------------------
        private void _UpdateModel()
        {
            // search row by row
            for (int i = 0; i < Range.ColumnCount; i++)
            {
                string name = (string)Range.Cells[i, SearchIndexName].Value;
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
                    table[row, column] = (double)Range.Cells[i, SearchIndexValue].Value;
                }
            }
        }

        public void Debug()
        {

        }
    }
}
