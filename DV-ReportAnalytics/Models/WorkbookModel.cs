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
        protected byte[] _buffer;

        public WorkbookModel()
        {
            // initialize application object
            _application = new Application();
            _application.DisplayAlerts = false;
            _workbook = _application.ActiveWorkbook;
            _worksheet = _workbook.ActiveSheet;
        }

        protected virtual void _SaveToBuffer()
        {
            string temp = Path.GetTempFileName();
            _workbook.SaveCopyAs(temp);
            _buffer = File.ReadAllBytes(temp);
            File.Delete(temp);
        }

        // update the workbook according to the config
        public virtual void Update(XmlDocument config)
        {
            // do something with the configuration

            _SaveToBuffer();
            // raise event
            // if there are handlers registerd, give them the buffer
            if (WorkbookUpdate != null)
                WorkbookUpdate.Invoke(this, new WorkbookUpdateEventArgs(_buffer));
        }

        public virtual void Open(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
            // get buffer
            _buffer = File.ReadAllBytes(path);
            // open new workbook
            _application.Workbooks.Close();
            _workbook = _application.Workbooks.Open(path);
            // raise event
            if (WorkbookUpdate != null)
                WorkbookUpdate.Invoke(this, new WorkbookUpdateEventArgs(_buffer));
        }

        // async method
        public virtual async void SaveAs(string path)
        {
            // overwriting
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                fs.Seek(0, SeekOrigin.Begin);
                await fs.WriteAsync(_buffer, 0, _buffer.Length);
            }
        }
    }
}
