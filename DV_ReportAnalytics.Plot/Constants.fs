namespace DV_ReportAnalytics.Plot

module public CONSTANTS =
    [<LiteralAttribute>]
    let HTML_TEMPLATE = 
        """
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8" />
    <script src="plotly-latest.min.js"></script>
</head>
<body>
    {0}
</body>
</html>
        """