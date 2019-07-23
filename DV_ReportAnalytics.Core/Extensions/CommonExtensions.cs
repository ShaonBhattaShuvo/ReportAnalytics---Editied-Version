using System;
using System.Collections.Generic;

namespace DV_ReportAnalytics.Core
{
    public static class CommonExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
                action(item);
        }

        public static T GetPropertyValue<T>(this object source, string property)
        {
            return (T)source.GetType().GetProperty(property).GetValue(source);
        }

        public static object ToObject<T>(T source)
        {
            return (object)source;
        }
    }
}
