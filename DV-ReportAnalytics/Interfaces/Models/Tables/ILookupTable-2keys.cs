using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface ILookupTable<TKeyRow, TKeyColumn, TValue>
    {
        string Name { get; }

        // provide a convenient way to access table using index
        TValue this[TKeyRow row, TKeyColumn column] { set; get; }

        // get keys for rows
        List<TKeyRow> GetKeysRows();

        // get keys for columns
        List<TKeyColumn> GetKeysColumns();

        // passing empty default value to get the whole table
        TData3<TKeyColumn, TKeyRow, TValue> GetData(TKeyColumn[] columnRange, TKeyRow[] rowRange);

        //// get transposed table
        //TData3D<TKeyRow, TKeyColumn, TValue> GetData3DTransposed(TKeyRow[] rowRange, TKeyColumn[] columnRange);

        // get a tuple that contains the number of rows and columns
        (int rows, int columns) GetDimension();
    }
}
