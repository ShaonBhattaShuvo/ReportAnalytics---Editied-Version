using System;
using System.Xml;

namespace DV_ReportAnalytics.UI
{
    internal interface IBaseForm
    {
        event Action<object, ContentUpdateEventArgs> ContentUpdated;
        void UpdateContent(XmlDocument doc);
    }
}
