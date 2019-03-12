﻿using System;
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
        public event WorkbookUpdateEventHandler WorkbookUpdated;
        public event WorkbookUpdateEventHandler WorkbookOpen;
        protected Application _application;
        protected Workbook _workbook;
        protected Worksheet _worksheet;
        protected byte[] _buffer;

        public WorkbookModel()
        {
            // initialize application object
            _application = new Application();
        }

        // update the workbook according to the config
        public virtual void Update(XmlDocument config)
        {
            // do something with the configuration

            _UpdateBuffer();
            // raise event
            // if there are handlers registerd, give them the buffer
            if (WorkbookUpdated != null)
                WorkbookUpdated.Invoke(this, new WorkbookUpdateEventArgs(_buffer));
        }

        public virtual void Open(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
            // get buffer
            _ReadFileToBuffer(path);
            // open new workbook
            _application.Workbooks.Close();
            _workbook = _application.Workbooks.Open(path);
            // raise event
            if (WorkbookOpen != null)
                WorkbookOpen.Invoke(this, new WorkbookUpdateEventArgs(_buffer));
        }

        // write memory to file
        public virtual void SaveAs(string path)
        {
            // overwriting
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                fs.Seek(0, SeekOrigin.Begin);
                fs.Write(_buffer, 0, _buffer.Length);
            }
        }

        // save current workbook to buffer
        protected virtual void _UpdateBuffer()
        {
            string temp = Path.GetTempFileName();
            _workbook.SaveCopyAs(temp);
            _ReadFileToBuffer(temp);
            File.Delete(temp);
        }
        
        // open file to buffer
        protected virtual void _ReadFileToBuffer(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                fs.Seek(0, SeekOrigin.Begin);
                // initial buffer
                _buffer = new byte[fs.Length];
                // read bytes to buffer
                fs.Read(_buffer, 0, _buffer.Length);
            }
        }
    }
}
