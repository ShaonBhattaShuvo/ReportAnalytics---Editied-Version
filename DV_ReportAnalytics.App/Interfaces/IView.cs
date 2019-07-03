using System;
using System.ComponentModel;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IView : IDisposable, INotifyPropertyChanged
    {
        event EventHandler RequestClosed;
        void Close();
        void Show();
    }
}
