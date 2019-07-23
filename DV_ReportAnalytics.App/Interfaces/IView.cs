using System;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IView
    {
        event EventHandler RequestClosed;
        void Close();
        void Show();
        void BindData(object source, object arguments);
    }
}
