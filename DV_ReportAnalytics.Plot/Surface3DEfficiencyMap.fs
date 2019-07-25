namespace DV_ReportAnalytics.Plot
open DV_ReportAnalytics.Core
open XPlot.Plotly

module public Surface3DEfficiencyMap =
    let CreateInlineHTML(table : TableInfo, layout : Layout, colorscale : obj list list) : string =
        let chart =
            Surface(x = table.ColumnHeader, y = table.RowHeader, z = table.DataBody, colorscale = colorscale)
            |> Chart.Plot
            |> Chart.WithLayout layout
            |> Chart.WithWidth 700
            |> Chart.WithHeight 500
       
        chart.GetInlineHtml()

    let GetDefaultLayout(title : string, xtext : string, ytext : string, ztext : string) : Layout = 
        Layout(
            title = title,
            autosize = false,
            margin =
                Margin(
                    l = 65.,
                    r = 50.,
                    b = 65.,
                    t = 90.
                ),
            scene =
                Scene(
                    xaxis = 
                        Xaxis(
                            title = xtext,
                            autorange = true,
                            ticks = 3,
                            ticklen = 4.0,
                            tickwidth = 3.0
                        ),
                    yaxis = 
                        Yaxis(
                            title = ytext,
                            autorange = true,
                            ticks = 3,
                            ticklen = 4.0,
                            tickwidth = 3.0
                        ),
                    zaxis = 
                        Zaxis(
                            title = ztext,
                            autorange = true,
                            ticks = 3,
                            ticklen = 4.0,
                            tickwidth = 3.0
                        )
                )
        )

    let GetDefaultColorScale() =
        let colorscale = 
            [
                [box 0.0; box "#9e0142"]
                [0.1; "#d53e4f"]
                [0.2; "#f46d43"]
                [0.3; "#fdae61"]
                [0.4; "#fee08b"]
                [0.5; "#ffffbf"]
                [0.6; "#e6f598"]
                [0.7; "#abdda4"]
                [0.8; "#66c2a5"]
                [0.9; "#3288bd"]
                [1.0; "#5e4fa2"]
            ]
        colorscale