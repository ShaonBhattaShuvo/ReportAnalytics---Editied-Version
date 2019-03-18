using System;
using System.Xml;
using DV_ReportAnalytics.Events;
using SpreadsheetGear;

namespace DV_ReportAnalytics.Models
{
    internal abstract class WorkbookModel<T>: IWorkbookModel<T>
    {
        protected IRange _range;

        public abstract event WorkbookTableUpdateEventHandler<T> WorkbookTableUpdate;

        public abstract void SetDisplayConfig(XmlDocument config);

        public abstract string GetDisplayConfig();

        public abstract void SetRange(IRange range);

        public abstract void Read();

        // raise event
        protected abstract void _Update();
    }
}
