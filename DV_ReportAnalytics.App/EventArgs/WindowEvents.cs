using System;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    public class WizardSelectionChangedEventArgs : EventArgs
    {
        public ReportTypes Type { get; }
        public WizardSelectionChangedEventArgs(ReportTypes type) { Type = type; }
        public WizardSelectionChangedEventArgs(int index) { Type = (ReportTypes)index; }
    }

    public class EventArgs<T> : EventArgs
    {
        public T Value { get; }
        public EventArgs(T value) { Value = value; }
    }
}
