using System;

namespace DV_ReportAnalytics
{
    internal enum ModelTypes : int { None = 0, EPTReport };

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
