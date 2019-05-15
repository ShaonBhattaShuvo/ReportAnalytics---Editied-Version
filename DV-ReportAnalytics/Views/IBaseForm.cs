using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IBaseForm
    {
        event Action<object, ContentUpdateEventArgs> ContentUpdated;
        void UpdateContent(XmlDocument doc);
    }
}
