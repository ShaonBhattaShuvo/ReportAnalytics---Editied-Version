namespace DV_ReportAnalytics.Plot
open System

type Data3D =
    struct
        val x : Object[]
        val y : Object[]
        val z : Object[]
    end

type Label3D =
    struct
        val title : string
        val x : string
        val y : string
        val z : string
    end