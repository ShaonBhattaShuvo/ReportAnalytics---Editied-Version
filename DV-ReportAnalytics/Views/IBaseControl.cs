using System;
using System.Xml;
using System.Windows.Forms;

namespace DV_ReportAnalytics
{
    internal interface IBaseControl
    {
        XmlDocument Content { set; get; }
        event Action<object, ContentUpdateEventArgs> ContentUpdated;

        #region UserControl members
        DockStyle Dock { set; get; }
        void Show();
        void Hide();
        void Dispose();
        #endregion
    }
}
