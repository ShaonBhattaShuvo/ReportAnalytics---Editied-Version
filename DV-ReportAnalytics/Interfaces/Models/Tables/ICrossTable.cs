using System;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Models
{
    internal interface ICrossTable<TKeyRow, TKeyColumn, TValue>
    {
        string RowName { get; }
        string ColumnName { get; }
        string Name { get; }
        void SetValue(TKeyRow row, TKeyColumn column, TValue value);
        TValue GetValue(TKeyRow row, TKeyColumn column);
        TData3<TKeyColumn, TKeyRow, TValue> GetData3D(TKeyRow[] rowRange, TKeyColumn[] columnRange);
        TData3<TKeyRow, TKeyColumn, TValue> GetData3DTransposed(TKeyRow[] rowRange, TKeyColumn[] columnRange);
        (int rows, int columns) GetDimension();
    }
}
