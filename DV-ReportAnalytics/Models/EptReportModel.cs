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
            Update();
        }

        public void Remove(string name)
        {
            _tableDictionary.Remove(name);
            Update();
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
        private void Update()
        {
            if (WorkbookTableUpdate != null)
            {
                WorkbookTableUpdate.Invoke(this, new WorkbookTableUpdateEventArgs(TableNames));
            }
        }

        private bool OpenWorkbookView(string path)
        {
            WorkbookView wbv = _mainForm.WorkbookView;
            bool success;
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            wbv.GetLock();
            try
            {
                // close previous before open a new file
                wbv.ActiveWorkbook.Close();
                wbv.ActiveWorkbook = wbv.ActiveWorkbookSet.Workbooks.Open(path);
                wbv.Visible = true;
                success = true;
                //printAllWorkbooks();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = false;
            }
            finally
            {
                wbv.ReleaseLock();
            }
            return success;
        }

        private bool SaveWorkbookView(string path)
        {
            WorkbookView wbv = _mainForm.WorkbookView;
            bool success;
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            wbv.GetLock();
            try
            {
                wbv.ActiveWorkbook.SaveAs(path, SpreadsheetGear.FileFormat.OpenXMLWorkbook);
                success = true;
                //PrintAllWorkbooks();
            }
            catch (Exception e)
            {
                success = false;
            }
            finally
            {
                wbv.ReleaseLock();
            }
            return success;
        }

        private void PrintAllWorkbooks()
        {
            IWorkbooks wbs = _mainForm.WorkbookView.ActiveWorkbookSet.Workbooks;
            Console.WriteLine("--------WorkbookView Items------------");
            for (int i = 0; i < wbs.Count; i++)
            {
                Console.WriteLine(wbs[i].FullName);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
