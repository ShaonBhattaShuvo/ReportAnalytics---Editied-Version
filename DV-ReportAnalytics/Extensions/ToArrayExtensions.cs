using System;
using System.Collections.Generic;
using System.Linq;

namespace DV_ReportAnalytics.Extensions
{
    internal static class ToArrayExtensions
    {
        /// <summary>
        /// Conerts source to 2D array.
        /// </summary>
        /// <typeparam name="T">
        /// The type of item that must exist in the source.
        /// </typeparam>
        /// <param name="source">
        /// The source to convert.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if source is null.
        /// </exception>
        /// <returns>
        /// The 2D array of source items.
        /// </returns>
        public static T[,] To2DArray<T>(this List<List<T>> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("Source is null");
            }

            int max = source.Select(l => l).Max(l => l.Count());

            var result = new T[source.Count, max];

            for (int i = 0; i < source.Count; i++)
            {
                for (int j = 0; j < source[i].Count(); j++)
                {
                    result[i, j] = source[i][j];
                }
            }

            return result;
        }

        // convert keyroll to array
        public static K[] ToArray<K, V>(this Dictionary<K, V>.KeyCollection source)
        {
            K[] keys = new K[source.Count];
            source.CopyTo(keys, 0);
            return keys;
        }

        public static object[,] ToTableColArray<T>(this T[] source)
        {
            object[,] result = new object[source.Length, 1];
            for (int i = 0; i < source.Length; i++)
                result[i, 0] = source[i];
            return result;
        }

        public static object[,] ToTableRowArray<T>(this T[] source)
        {
            object[,] result = new object[1, source.Length];
            for (int i = 0; i < source.Length; i++)
                result[0, i] = source[i];
            return result;
        }

        public static object[,] ToTableDataArray<T>(this T[,] source)
        {
            object[,] result = new object[source.GetLength(0), source.GetLength(1)];
            Array.Copy(source, result, source.Length);
            return result;
        }
    }
}
