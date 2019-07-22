using System;
using System.Collections.Generic;
using System.Linq;

namespace DV_ReportAnalytics.Core
{
    public static class ToArrayExtensions
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

        public static T[] ToArray<S, T>(this S[] source, Converter<S, T> converter)
        {
            var result = Array.ConvertAll(source, converter);
            return result;
        }

        public static T[] ToArray<S, T>(this S[] source)
        {
            Type type = typeof(T);
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = (T)Convert.ChangeType(source[i], type);
            return result;
        }

        public static T[,] ToArray<S, T>(this S[,] source, Converter<S, T> converter)
        {
            T[,] result = new T[source.GetLength(0), source.GetLength(1)];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    result[i, j] = converter(source[i, j]); // TODO: optimize this O(n2) method
            return result;
        }

        public static T[,] ToArray<S, T>(this S[,] source)
        {
            Type type = typeof(T);
            T[,] result = new T[source.GetLength(0), source.GetLength(1)];
            for (int i = 0; i < source.GetLength(0); i++)
                for (int j = 0; j < source.GetLength(1); j++)
                    result[i, j] = (T)Convert.ChangeType(source[i, j], type); // TODO: optimize this O(n2) method
            return result;
        }

        public static T[,] ToRangeColumnArray<T>(this T[] source)
        {
            T[,] result = new T[source.Length, 1];
            for (int i = 0; i < source.Length; i++)
                result[i, 0] = source[i];
            return result;
        }

        public static T[,] ToRangeRowArray<T>(this T[] source)
        {
            T[,] result = new T[1, source.Length];
            for (int i = 0; i < source.Length; i++)
                result[0, i] = source[i];
            return result;
        }
    }
}
