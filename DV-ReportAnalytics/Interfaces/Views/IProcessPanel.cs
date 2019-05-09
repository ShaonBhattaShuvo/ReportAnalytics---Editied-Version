using System;
using System.Windows.Forms;
using System.Xml;

namespace DV_ReportAnalytics.Views
{
    internal interface IProcessPanel
    {
        // submit all contents on page
        XmlDocument Submit();
        void Reload(XmlDocument doc);
        
        // UserControl members
        DockStyle Dock { set; get; }
    }
}
