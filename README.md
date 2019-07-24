# D&V ReportAnalytics

> Read and process *xls/*xlsx files

> Data interpolation

> 3D surface graph plotting

**Badges will go here**

[![Build Status](http://img.shields.io/travis/badges/badgerbadgerbadger.svg?style=flat-square)](https://travis-ci.org/badges/badgerbadgerbadger)

## Built With
This project is based on .Net Framework 4.7.1.  
Open source library XPlot and Plotly.js are used for 3D surface plotting. The proprietary library SpreadsheetGear is also used for Excel sheet displaying and manipulation.
- [.Net Framework](https://dotnet.microsoft.com/)
- [SpreadSheetGear](https://www.spreadsheetgear.com/)
- [XPlot.Plotly](https://fslab.org/XPlot/plotly.html)
- [Plotly.js](https://plot.ly/javascript/)

## Get Started
This project is developed with Visual Studio 2019 Community version and compatible with older versions. Once the project is opened, NuGet Package Manager should automatically resolve dependent packages.

## Architecture
The application uses MVP (Model View Presenter) architecture which decouples visual presentation from actual logics.  
There are four layers in this project: GUI, App, Plot