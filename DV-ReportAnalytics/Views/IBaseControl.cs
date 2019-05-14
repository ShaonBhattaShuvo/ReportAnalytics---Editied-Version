using System;
using System.Xml;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IBaseControl
    {
        XmlDocument Content { set; get; }
        event Action<object, FormUpdateEventArgs> ContentUpdated;

        #region UserControl members
        DockStyle Dock { set; get; }
        void Show();
        void Dispose();
        #endregion
    }
}
