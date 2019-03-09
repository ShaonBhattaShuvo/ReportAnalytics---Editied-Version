using System;
using System.Xml;
using System.IO;
using DV_ReportAnalytics.Events;
using Microsoft.Office.Interop.Excel;

namespace DV_ReportAnalytics.Models
{
    internal abstract class WorkbookModel: IWorkbookModel
    {
        public string FileName { get; protected set; }
        public string FilePath { get; protected set; }
        public event WorkbookUpdateEventHandler WorkbookUpdate;
        public event WorkbookOpenEventHandler WorkbookOpen;
        protected Application _application;
        protected Workbook _workbook;
        protected Worksheet _worksheet;
        protected string _tempPath;

        public WorkbookModel()
        {
            // initialize application object
            _application = new Application();
            _application.DisplayAlerts = false;
            _tempPath = Path.GetTempFileName();
        }

        // update the workbook according to the config
        public virtual void Update(XmlDocument config)
        {
            // do something with the configuration
            _workbook.Save();

            // raise event
            // if there are handlers registerd, give them the buffer
            if (WorkbookUpdate != null)
            {
                byte[] buffer = File.ReadAllBytes(_tempPath);
                // send
                WorkbookUpdate.Invoke(this, new WorkbookUpdateEventArgs(buffer));
            }
        }

        public virtual void Open(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
            // open workbook
            Console.WriteLine(_application.Workbooks);
            _application.Workbooks.Close();
            _workbook = _application.Workbooks.Open(path);
            Console.WriteLine(_application.Workbooks);
            // save to temp file
            _workbook.SaveAs(_tempPath);
            // raise event
            if (WorkbookOpen != null)
                WorkbookOpen.Invoke(this, new WorkbookOpenEventArgs(path, true));
        }
    }
}
