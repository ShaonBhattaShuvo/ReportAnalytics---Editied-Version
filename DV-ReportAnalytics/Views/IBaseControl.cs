using System;
using System.Xml;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IBaseControl
    {
        XmlDocument Contents { set; get; }
        event Action<object, FormUpdateEventArgs> ContentsUpdated;

        #region UserControl members
        DockStyle Dock { set; get; }
        void Show();
        void Dispose();
        #endregion
    }
}
