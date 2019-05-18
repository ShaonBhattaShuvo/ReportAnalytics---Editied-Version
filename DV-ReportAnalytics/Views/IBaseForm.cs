using System;
using System.Xml;

namespace DV_ReportAnalytics
{
    internal interface IBaseForm
    {
        event Action<object, ContentUpdateEventArgs> ContentUpdated;
        void UpdateContent(XmlDocument doc);
    }
}
