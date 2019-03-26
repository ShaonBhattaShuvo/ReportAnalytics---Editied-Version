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
                return _tableDictionary.Keys.ToArray();
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
            _tableDictionary[name].Name = name;
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
                WorkbookTableUpdate.Invoke(this, new WorkbookTableUpdateEventArgs(TableNames));
            }
        }
    }
}
