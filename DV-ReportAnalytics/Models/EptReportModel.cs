using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Models
{
    internal sealed class EptReportModel : WorkbookModel, IEptReportModel
    {
        // ---------fields and properties-------------------------
        private Dictionary<string, bool> _tableCheckedStatus;
        private Regex _searchFilter;
        private Dictionary<string, EptTable> _tableDictionary;
        public string InputSheetName { set; get; }
        public string OutputSheetName { set; get; }
        public string Name { set; get; }
        public int SearchNameIndex { set; get; }
        public int SearchValueIndex { set; get; }
        public int SpeedInterp { set; get; }
        public int TorqueInterp { set; get; }

        public string[] TableNames
        {
            get
            {
                string[] keys = new string[_tableDictionary.Keys.Count];
                _tableDictionary.Keys.CopyTo(keys, 0);
                return keys;
            }
        }

        public string ResultFormat {
            set
            {
                if (value == _searchFilter.ToString())
                {
                    _searchFilter = new Regex(value);
                    _Refresh();
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
                table : new EptTable();
            }
        }
        

        // --------------constructor----------------
        public EptReportModel(string name, string input, string output, string filter,
            int indexName, int indexValue): base()
        {
            Name = name;
            InputSheetName = input;
            OutputSheetName = output;
            SearchNameIndex = indexName;
            SearchValueIndex = indexValue;
            _searchFilter = new Regex(filter);
            // refresh content
            _Refresh();
        }

        // ----------------methods------------------
        private void _Refresh()
        {

        }

        public TEptConfig GetConfig()
        {
            return new TEptConfig(_tableCheckedStatus, SpeedInterp, TorqueInterp);
        }

        public void Debug()
        {
            Console.WriteLine("Count: {0}", _application.Workbooks.Count);

        }
    }
}
