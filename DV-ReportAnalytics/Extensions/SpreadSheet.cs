using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetGear;

namespace DV_ReportAnalytics
{
    internal static class SpreadSheet
    {
        public static object[,] ToRangeColumnArray<T>(this T[] source)
        {
            object[,] result = new object[source.Length, 1];
            for (int i = 0; i < source.Length; i++)
                result[i, 0] = source[i];
            return result;
        }

        public static object[,] ToRangeRowArray<T>(this T[] source)
        {
            object[,] result = new object[1, source.Length];
            for (int i = 0; i < source.Length; i++)
                result[0, i] = source[i];
            return result;
        }

        public static object[,] ToRangeArray<T>(this T[,] source)
        {
            object[,] result = new object[source.GetLength(0), source.GetLength(1)];
            Array.Copy(source, result, source.Length);
            return result;
        }

        public static IRange FirstCell(this IRange source)
        {
            return source.Cells[0, 0];
        }

        public static IRange LastCell(this IRange source)
        {
            return source.Cells[source.RowCount - 1, source.ColumnCount - 1];
        }

        public static IRange CellBelow(this IRange source)
        {
            return source.Cells[source.RowCount, 0];
        }

        public static IRange CellAbove(this IRange source)
        {
            return source.Cells[-1, 0];
        }

        public static IRange CellRight(this IRange source)
        {
            return source.Cells[0, source.ColumnCount];
        }

        public static IRange CellLeft(this IRange source)
        {
            return source.Cells[0, -1];
        }

        public static IRange FirstColumn(this IRange source)
        {
            return source.FirstCell().EntireColumn;
        }

        public static IRange FirstRow(this IRange source)
        {
            return source.FirstCell().EntireRow;
        }

        public static IRange LastColumn(this IRange source)
        {
            return source.LastCell().EntireColumn;
        }

        public static IRange LastRow(this IRange source)
        {
            return source.LastCell().EntireRow;
        }

        public static IRange RowBelow(this IRange source)
        {
            return source.LastRow().CellBelow().EntireRow;
        }

        public static IRange RowAbove(this IRange source)
        {
            return source.FirstRow().CellAbove().EntireRow;
        }

        public static IRange ColumnRight(this IRange source)
        {
            return source.LastColumn().CellRight().EntireColumn;
        }

        public static IRange ColumnLeft(this IRange source)
        {
            return source.FirstColumn().CellLeft().EntireColumn;
        }
    }
}
