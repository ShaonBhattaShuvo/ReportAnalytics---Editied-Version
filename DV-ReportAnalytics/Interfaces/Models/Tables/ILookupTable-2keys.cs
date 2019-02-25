using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface ILookupTable<TKeyRow, TKeyColumn, TValue>
    {
        string Name { get; }
        string keyRowName { get; }
        string keyColumnName { get; }
        string ValueName { get; }

        // provide a convenient way to access table using index
        TValue this[TKeyRow row, TKeyColumn column] { set; get; }

        // passing empty default value to get the whole table
        TData3D<TKeyColumn, TKeyRow, TValue> GetData3D(TKeyRow[] rowRange, TKeyColumn[] columnRange);

        // get transposed table
        TData3D<TKeyRow, TKeyColumn, TValue> GetData3DTransposed(TKeyRow[] rowRange, TKeyColumn[] columnRange);

        // get a tuple that contains the number of rows and columns
        (int rows, int columns) GetDimension();
    }
}
