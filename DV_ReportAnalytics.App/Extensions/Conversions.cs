using System;

namespace DV_ReportAnalytics.App
{
    public static class Conversions
    {
        public static int LetterToNumberColumn(string source)
        {
            int result;
            try
            {
                result = Convert.ToInt32(source);
            }
            catch
            {
                string upper = source.ToUpper();
                result = 0;
                for (int i = 0; i < upper.Length; i++)
                {
                    result *= 26;
                    result += (upper[i] - 'A') + 1;
                }
            }
            return result;
        }

        public static string NumberToLetterColumn(int source)
        {
            string result = string.Empty;
            int dividend = source;
            int modulo;
            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                dividend = (dividend - modulo) / 26;
                result = Convert.ToChar(modulo + 'A').ToString() + result;
            }
            return result;
        }
    }
}
