using System;
using DV_ReportAnalytics.Constants;

namespace DV_ReportAnalytics.Extensions
{
    internal static class ToEnumExtensions
    {
        public static ModelTypes ToModelTypes(this string source)
        {
            // when fail fall back to default (0)
            Enum.TryParse<ModelTypes>(source, false, out ModelTypes t);
            return t;
        }
    }
}
