using System;

namespace DV_ReportAnalytics.App
{
    public class EventArgs<T> : EventArgs
    {
        public T Value { get; }
        public EventArgs(T value) { Value = value; }
    }
}
