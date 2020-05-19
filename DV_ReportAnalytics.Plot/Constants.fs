namespace DV_ReportAnalytics.Plot

module public CONSTANTS =
    [<LiteralAttribute>]
    let HTML_TEMPLATE = 
        """
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8" />
               <script src="https://cdn.plot.ly/plotly-latest.min.js"></script>
               <script src="plotly-latest.min.js"></script>
</head>
<body>
    <h1 style="text-align:left;">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp D&V Report Analytics Software</h1>
    <h3 style="text-align:left;">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    &copy D&V Electronics, Canada.</h3>
    {0}
</body>
</html>
        """