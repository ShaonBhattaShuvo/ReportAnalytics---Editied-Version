using System;
using System.IO;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    internal abstract class WorkbookModel: IWorkbookModel
    {
        public string FileName { get; }
        public string FilePath { get; }
        public event WorkbookUpdateEventHandler WorkbookUpdate;

        public WorkbookModel(string path)
        {
            FileName = Path.GetFileName(path);
            FilePath = path;
        }

        // update the workbook according to the config
        public virtual void Update(WorkbookConfigUpdateEventArgs e)
        {
            if (WorkbookUpdate != null)
                WorkbookUpdate.Invoke(this, new WorkbookUpdateEventArgs(File.ReadAllBytes(FilePath)));
        }
    }
}
