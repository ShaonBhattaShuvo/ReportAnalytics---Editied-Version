﻿using System;
using System.Collections.Generic;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    interface ILookupTable<TKeyRow, TKeyColumn, TValue>
    {
        string Name { set; get; }
        string KeyRowName { set; get; }
        string KeyColumnName { set; get; }
        string ValueName { set; get; }
        string KeyRowSuffix { set; get; }
        string KeyColumnSuffix { set; get; }
        string ValueSuffix { set; get; }
        // provide a convenient way to access table using index
        TValue this[TKeyRow row, TKeyColumn column] { set; get; }

        // get keys for rows
        TKeyRow[] GetKeysRows();

        // get keys for columns
        TKeyColumn[] GetKeysColumns();

        // get data by range
        TData3<TKeyColumn, TKeyRow, TValue> GetData(TKeyColumn[] columnRange, TKeyRow[] rowRange);

        // get all data
        TData3<TKeyColumn, TKeyRow, TValue> GetData();

        //// get transposed table
        //TData3D<TKeyRow, TKeyColumn, TValue> GetData3DTransposed(TKeyRow[] rowRange, TKeyColumn[] columnRange);

        // get a tuple that contains the number of rows and columns
        (int rows, int columns) GetDimension();
    }
}
