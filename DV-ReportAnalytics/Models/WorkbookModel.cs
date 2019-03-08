using System;
using System.Xml;
using System.IO;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    internal abstract class WorkbookModel: IWorkbookModel
    {
        public string FileName { get; protected set; }
        public string FilePath { get; protected set; }
        public event WorkbookUpdateEventHandler WorkbookUpdate;
        public event WorkbookOpenEventHandler WorkbookOpen;

        //public WorkbookModel(string path)
        //{
        //    FileName = Path.GetFileName(path);
        //    FilePath = path;
        //}

        // update the workbook according to the config
        public virtual void Update(XmlDocument config)
        {
            // raise event
            if (WorkbookUpdate != null)
            {

            }
        }

        public virtual void Open(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
            // raise event
            if (WorkbookOpen != null)
                WorkbookOpen.Invoke(this, new WorkbookOpenEventArgs(path, true));
        }
    }
}
