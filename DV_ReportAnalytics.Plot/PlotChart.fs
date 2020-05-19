namespace DV_ReportAnalytics.Plot
open System
open System.IO
open DV_ReportAnalytics.Core

module public PlotChart =
    let CreateSurfaceHTML(path : string, tables : seq<TableInfo>) : string =
        let segments = new System.Text.StringBuilder()
        let colorscale = Surface3DEfficiencyMap.GetDefaultColorScale()

        for table in tables do
            let layout = Surface3DEfficiencyMap.GetDefaultLayout(
                table.Label :?> string, 
                table.ColumnLabel :?> string, 
                table.RowLabel :?> string, 
                "")
            let seg = Surface3DEfficiencyMap.CreateInlineHTML(table, layout, colorscale)
            segments.Append(seg)

        let html = String.Format(CONSTANTS.HTML_TEMPLATE, segments.ToString())
        File.WriteAllText(path, html)
        (html)