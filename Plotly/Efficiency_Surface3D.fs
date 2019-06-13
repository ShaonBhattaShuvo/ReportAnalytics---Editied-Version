namespace Plotly
open XPlot.Plotly
open System

module public Efficiency_Surface3D =
    let Create(title : string, dataZ : Object[,]) : string =
        let layout =
            Layout(
                title = title,
                autosize = false,
                margin =
                    Margin(
                        l = 65.,
                        r = 50.,
                        b = 65.,
                        t = 90.
                    )
            )
        let chart =
            Surface(z = dataZ)
            |> Chart.Plot
            |> Chart.WithLayout layout
            |> Chart.WithWidth 700
            |> Chart.WithHeight 500
       
        chart.GetInlineHtml()