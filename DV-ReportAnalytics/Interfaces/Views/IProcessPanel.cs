using System;
using System.Xml;

namespace DV_ReportAnalytics.Views
{
    internal interface IProcessPanel
    {
        // submit all contents on page
        XmlDocument Submit();
        void Reload(XmlDocument doc);
    }
}
