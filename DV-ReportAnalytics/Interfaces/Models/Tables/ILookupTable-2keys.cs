using System;

namespace DV_ReportAnalytics.Models
{
    internal interface ILookupTable<TKeyRow, TKeyColumn, TValue>
    {
        // provide a convenient way to access table using index
        TValue this[TKeyRow row, TKeyColumn column] { set; get; }

        // get keys for rows
        TKeyRow[] GetKeysRows();

        // get keys for columns
        TKeyColumn[] GetKeysColumns();

        // get a tuple that contains the number of rows and columns
        (int rows, int columns) GetDimension();
    }
}
