using System;
using System.ComponentModel;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IView
    {
        event EventHandler RequestClosed;
        void Close();
        void Show();
    }
}
