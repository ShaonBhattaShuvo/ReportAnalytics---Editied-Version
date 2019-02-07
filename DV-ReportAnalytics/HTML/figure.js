
function getFigure () {
    var figure = {
    "frames": [], 
    "layout": {
        "clickmode": "event+select", 
        "autosize": true, 
        "modebar": {
            "orientation": "h"
        }, 
        "xaxis": {
            "range": [
                0, 
                0
            ], 
            "autorange": false
        }, 
        "dragmode": "turntable", 
        "yaxis": {
            "range": [
                0, 
                0
            ], 
            "autorange": false
        }, 
        "paper_bgcolor": "rgb(255, 255, 255)", 
        "title": {
            "x": 0.5, 
            "text": "My Title"
        }, 
        "colorway": [
            "#AA0DFE", 
            "#3283FE", 
            "#85660D", 
            "#782AB6", 
            "#565656", 
            "#1C8356", 
            "#16FF32", 
            "#F7E1A0", 
            "#E2E2E2", 
            "#1CBE4F", 
            "#C4451C", 
            "#DEA0FD", 
            "#FE00FA", 
            "#325A9B", 
            "#FEAF16", 
            "#F8A19F", 
            "#90AD1C", 
            "#F6222E", 
            "#1CFFCE", 
            "#2ED9FF", 
            "#B10DA1", 
            "#C075A6", 
            "#FC1CBF", 
            "#B00068", 
            "#FBE426", 
            "#FA0087"
        ], 
        "separators": ".,", 
        "scene": {
            "dragmode": "turntable", 
            "yaxis": {
                "showspikes": true, 
                "ticklen": 4, 
                "tickwidth": 3, 
                "ticksuffix": "", 
                "title": {
                    "text": "Torque (NM)"
                }, 
                "zerolinewidth": 1, 
                "ticks": "inside", 
                "spikethickness": 2, 
                "zerolinecolor": "rgb(68, 68, 68)", 
                "range": [
                    4, 
                    7
                ], 
                "backgroundcolor": "rgb(255, 255, 255)", 
                "nticks": 8, 
                "type": "linear", 
                "autorange": true
            }, 
            "aspectmode": "auto", 
            "camera": {
                "eye": {
                    "y": -1.5726045702388716, 
                    "x": -1.1791296830055429, 
                    "z": 0.9077819431554384
                }, 
                "up": {
                    "y": 0, 
                    "x": 0, 
                    "z": 1
                }, 
                "center": {
                    "y": 0, 
                    "x": 0, 
                    "z": 0
                }
            }, 
            "zaxis": {
                "showspikes": true, 
                "ticklen": 4, 
                "tickwidth": 3, 
                "ticksuffix": "", 
                "title": {
                    "text": "Power (W)"
                }, 
                "zerolinewidth": 1, 
                "ticks": "inside", 
                "spikethickness": 2, 
                "zerolinecolor": "rgb(68, 68, 68)", 
                "backgroundcolor": "rgb(255, 255, 255)", 
                "nticks": 0, 
                "autorange": true
            }, 
            "xaxis": {
                "showspikes": true, 
                "ticklen": 5, 
                "tickwidth": 3, 
                "ticksuffix": "", 
                "tickmode": "auto", 
                "title": {
                    "text": "Speed (RPM)"
                }, 
                "tickangle": "auto", 
                "ticks": "inside", 
                "spikethickness": 2, 
                "zerolinecolor": "rgb(68, 68, 68)", 
                "range": [
                    0, 
                    4000
                ], 
                "backgroundcolor": "rgb(255, 255, 255)", 
                "zerolinewidth": 1, 
                "tickformat": "", 
                "nticks": 2, 
                "type": "linear", 
                "autorange": true, 
                "exponentformat": "000"
            }, 
            "aspectratio": {
                "y": 1, 
                "x": 1, 
                "z": 1
            }
        }, 
        "font": {
            "family": "Arial"
        }, 
        "hoverlabel": {
            "bordercolor": "#000", 
            "bgcolor": "#FFF", 
            "font": {
                "color": "#000", 
                "family": "Arial"
            }
        }, 
        "colorscale": {
            "diverging": [
                [
                    0, 
                    "#8e0152"
                ], 
                [
                    0.1, 
                    "#c51b7d"
                ], 
                [
                    0.2, 
                    "#de77ae"
                ], 
                [
                    0.3, 
                    "#f1b6da"
                ], 
                [
                    0.4, 
                    "#fde0ef"
                ], 
                [
                    0.5, 
                    "#f7f7f7"
                ], 
                [
                    0.6, 
                    "#e6f5d0"
                ], 
                [
                    0.7, 
                    "#b8e186"
                ], 
                [
                    0.8, 
                    "#7fbc41"
                ], 
                [
                    0.9, 
                    "#4d9221"
                ], 
                [
                    1, 
                    "#276419"
                ]
            ], 
            "sequential": [
                [
                    0, 
                    "#0508b8"
                ], 
                [
                    0.08333333333333333, 
                    "#1910d8"
                ], 
                [
                    0.16666666666666666, 
                    "#3c19f0"
                ], 
                [
                    0.25, 
                    "#6b1cfb"
                ], 
                [
                    0.3333333333333333, 
                    "#981cfd"
                ], 
                [
                    0.4166666666666667, 
                    "#bf1cfd"
                ], 
                [
                    0.5, 
                    "#dd2bfd"
                ], 
                [
                    0.5833333333333334, 
                    "#f246fe"
                ], 
                [
                    0.6666666666666666, 
                    "#fc67fd"
                ], 
                [
                    0.75, 
                    "#fe88fc"
                ], 
                [
                    0.8333333333333334, 
                    "#fea5fd"
                ], 
                [
                    0.9166666666666666, 
                    "#febefe"
                ], 
                [
                    1, 
                    "#fec3fe"
                ]
            ], 
            "sequentialminus": [
                [
                    0, 
                    "#0508b8"
                ], 
                [
                    0.08333333333333333, 
                    "#1910d8"
                ], 
                [
                    0.16666666666666666, 
                    "#3c19f0"
                ], 
                [
                    0.25, 
                    "#6b1cfb"
                ], 
                [
                    0.3333333333333333, 
                    "#981cfd"
                ], 
                [
                    0.4166666666666667, 
                    "#bf1cfd"
                ], 
                [
                    0.5, 
                    "#dd2bfd"
                ], 
                [
                    0.5833333333333334, 
                    "#f246fe"
                ], 
                [
                    0.6666666666666666, 
                    "#fc67fd"
                ], 
                [
                    0.75, 
                    "#fe88fc"
                ], 
                [
                    0.8333333333333334, 
                    "#fea5fd"
                ], 
                [
                    0.9166666666666666, 
                    "#febefe"
                ], 
                [
                    1, 
                    "#fec3fe"
                ]
            ]
        }, 
        "template": {
            "data": {
                "mesh3d": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "type": "mesh3d"
                    }
                ], 
                "scattercarpet": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scattercarpet"
                    }
                ], 
                "scatterternary": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scatterternary"
                    }
                ], 
                "surface": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "type": "surface"
                    }
                ], 
                "table": [
                    {
                        "header": {
                            "line": {
                                "color": "white"
                            }, 
                            "fill": {
                                "color": "#C8D4E3"
                            }
                        }, 
                        "cells": {
                            "line": {
                                "color": "white"
                            }, 
                            "fill": {
                                "color": "#EBF0F8"
                            }
                        }, 
                        "type": "table"
                    }
                ], 
                "scatterpolargl": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scatterpolargl"
                    }
                ], 
                "contour": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "autocolorscale": true, 
                        "type": "contour"
                    }
                ], 
                "carpet": [
                    {
                        "type": "carpet", 
                        "baxis": {
                            "linecolor": "#C8D4E3", 
                            "gridcolor": "#C8D4E3", 
                            "endlinecolor": "#2a3f5f", 
                            "minorgridcolor": "#C8D4E3", 
                            "startlinecolor": "#2a3f5f"
                        }, 
                        "aaxis": {
                            "linecolor": "#C8D4E3", 
                            "gridcolor": "#C8D4E3", 
                            "endlinecolor": "#2a3f5f", 
                            "minorgridcolor": "#C8D4E3", 
                            "startlinecolor": "#2a3f5f"
                        }
                    }
                ], 
                "contourcarpet": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "type": "contourcarpet"
                    }
                ], 
                "heatmap": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "autocolorscale": true, 
                        "type": "heatmap"
                    }
                ], 
                "scattermapbox": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scattermapbox"
                    }
                ], 
                "scatter3d": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scatter3d"
                    }
                ], 
                "scattergl": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scattergl"
                    }
                ], 
                "histogram": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "histogram"
                    }
                ], 
                "heatmapgl": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "type": "heatmapgl"
                    }
                ], 
                "scatterpolar": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scatterpolar"
                    }
                ], 
                "histogram2d": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "autocolorscale": true, 
                        "type": "histogram2d"
                    }
                ], 
                "scattergeo": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scattergeo"
                    }
                ], 
                "bar": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "bar"
                    }
                ], 
                "choropleth": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "type": "choropleth"
                    }
                ], 
                "parcoords": [
                    {
                        "line": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "parcoords"
                    }
                ], 
                "histogram2dcontour": [
                    {
                        "colorbar": {
                            "outlinewidth": 0, 
                            "ticks": ""
                        }, 
                        "autocolorscale": true, 
                        "type": "histogram2dcontour"
                    }
                ], 
                "scatter": [
                    {
                        "marker": {
                            "colorbar": {
                                "outlinewidth": 0, 
                                "ticks": ""
                            }
                        }, 
                        "type": "scatter"
                    }
                ]
            }, 
            "layout": {
                "shapedefaults": {
                    "opacity": 0.4, 
                    "line": {
                        "width": 0
                    }, 
                    "fillcolor": "#506784"
                }, 
                "polar": {
                    "radialaxis": {
                        "ticks": "", 
                        "gridcolor": "#EBF0F8", 
                        "linecolor": "#EBF0F8"
                    }, 
                    "bgcolor": "white", 
                    "angularaxis": {
                        "ticks": "", 
                        "gridcolor": "#EBF0F8", 
                        "linecolor": "#EBF0F8"
                    }
                }, 
                "colorway": [
                    "#636efa", 
                    "#EF553B", 
                    "#00cc96", 
                    "#ab63fa", 
                    "#19d3f3", 
                    "#e763fa"
                ], 
                "xaxis": {
                    "automargin": true, 
                    "zerolinewidth": 2, 
                    "ticks": "", 
                    "zerolinecolor": "#EBF0F8", 
                    "gridcolor": "#EBF0F8", 
                    "linecolor": "#EBF0F8"
                }, 
                "title": {
                    "x": 0.05
                }, 
                "paper_bgcolor": "white", 
                "plot_bgcolor": "white", 
                "yaxis": {
                    "automargin": true, 
                    "zerolinewidth": 2, 
                    "ticks": "", 
                    "zerolinecolor": "#EBF0F8", 
                    "gridcolor": "#EBF0F8", 
                    "linecolor": "#EBF0F8"
                }, 
                "scene": {
                    "zaxis": {
                        "linecolor": "#EBF0F8", 
                        "ticks": "", 
                        "gridwidth": 2, 
                        "showbackground": true, 
                        "zerolinecolor": "#EBF0F8", 
                        "gridcolor": "#DFE8F3", 
                        "backgroundcolor": "white"
                    }, 
                    "xaxis": {
                        "linecolor": "#EBF0F8", 
                        "ticks": "", 
                        "gridwidth": 2, 
                        "showbackground": true, 
                        "zerolinecolor": "#EBF0F8", 
                        "gridcolor": "#DFE8F3", 
                        "backgroundcolor": "white"
                    }, 
                    "yaxis": {
                        "linecolor": "#EBF0F8", 
                        "ticks": "", 
                        "gridwidth": 2, 
                        "showbackground": true, 
                        "zerolinecolor": "#EBF0F8", 
                        "gridcolor": "#DFE8F3", 
                        "backgroundcolor": "white"
                    }
                }, 
                "colorscale": {
                    "diverging": [
                        [
                            0, 
                            "#8e0152"
                        ], 
                        [
                            0.1, 
                            "#c51b7d"
                        ], 
                        [
                            0.2, 
                            "#de77ae"
                        ], 
                        [
                            0.3, 
                            "#f1b6da"
                        ], 
                        [
                            0.4, 
                            "#fde0ef"
                        ], 
                        [
                            0.5, 
                            "#f7f7f7"
                        ], 
                        [
                            0.6, 
                            "#e6f5d0"
                        ], 
                        [
                            0.7, 
                            "#b8e186"
                        ], 
                        [
                            0.8, 
                            "#7fbc41"
                        ], 
                        [
                            0.9, 
                            "#4d9221"
                        ], 
                        [
                            1, 
                            "#276419"
                        ]
                    ], 
                    "sequential": [
                        [
                            0, 
                            "#0508b8"
                        ], 
                        [
                            0.0893854748603352, 
                            "#1910d8"
                        ], 
                        [
                            0.1787709497206704, 
                            "#3c19f0"
                        ], 
                        [
                            0.2681564245810056, 
                            "#6b1cfb"
                        ], 
                        [
                            0.3575418994413408, 
                            "#981cfd"
                        ], 
                        [
                            0.44692737430167595, 
                            "#bf1cfd"
                        ], 
                        [
                            0.5363128491620112, 
                            "#dd2bfd"
                        ], 
                        [
                            0.6256983240223464, 
                            "#f246fe"
                        ], 
                        [
                            0.7150837988826816, 
                            "#fc67fd"
                        ], 
                        [
                            0.8044692737430168, 
                            "#fe88fc"
                        ], 
                        [
                            0.8938547486033519, 
                            "#fea5fd"
                        ], 
                        [
                            0.9832402234636871, 
                            "#febefe"
                        ], 
                        [
                            1, 
                            "#fec3fe"
                        ]
                    ], 
                    "sequentialminus": [
                        [
                            0, 
                            "#0508b8"
                        ], 
                        [
                            0.0893854748603352, 
                            "#1910d8"
                        ], 
                        [
                            0.1787709497206704, 
                            "#3c19f0"
                        ], 
                        [
                            0.2681564245810056, 
                            "#6b1cfb"
                        ], 
                        [
                            0.3575418994413408, 
                            "#981cfd"
                        ], 
                        [
                            0.44692737430167595, 
                            "#bf1cfd"
                        ], 
                        [
                            0.5363128491620112, 
                            "#dd2bfd"
                        ], 
                        [
                            0.6256983240223464, 
                            "#f246fe"
                        ], 
                        [
                            0.7150837988826816, 
                            "#fc67fd"
                        ], 
                        [
                            0.8044692737430168, 
                            "#fe88fc"
                        ], 
                        [
                            0.8938547486033519, 
                            "#fea5fd"
                        ], 
                        [
                            0.9832402234636871, 
                            "#febefe"
                        ], 
                        [
                            1, 
                            "#fec3fe"
                        ]
                    ]
                }, 
                "ternary": {
                    "bgcolor": "white", 
                    "baxis": {
                        "ticks": "", 
                        "gridcolor": "#DFE8F3", 
                        "linecolor": "#A2B1C6"
                    }, 
                    "caxis": {
                        "ticks": "", 
                        "gridcolor": "#DFE8F3", 
                        "linecolor": "#A2B1C6"
                    }, 
                    "aaxis": {
                        "ticks": "", 
                        "gridcolor": "#DFE8F3", 
                        "linecolor": "#A2B1C6"
                    }
                }, 
                "hovermode": "closest", 
                "font": {
                    "color": "#2a3f5f"
                }, 
                "geo": {
                    "showland": true, 
                    "bgcolor": "white", 
                    "showlakes": true, 
                    "landcolor": "white", 
                    "subunitcolor": "#C8D4E3", 
                    "lakecolor": "white"
                }, 
                "annotationdefaults": {
                    "arrowwidth": 1, 
                    "arrowhead": 0, 
                    "arrowcolor": "#506784"
                }
            }, 
            "themeRef": "PLOTLY_WHITE"
        }, 
        "hovermode": "closest", 
        "showlegend": false, 
        "margin": {
            "t": 80
        }, 
        "annotations": [], 
        "legend": {
            "bordercolor": "#444", 
            "yanchor": "auto", 
            "traceorder": "normal", 
            "xanchor": "left", 
            "orientation": "v", 
            "bgcolor": "white", 
            "borderwidth": 0, 
            "valign": "middle", 
            "y": 1, 
            "x": 1, 
            "font": {
                "color": "#2a3f5f", 
                "family": "Arial", 
                "size": 12
            }
        }
    }, 
    "data": [
        {
            "lightposition": {
                "y": 0
            }, 
            "reversescale": true, 
            "autocolorscale": false, 
            "name": "my trace 0", 
            "colorscale": [
                [
                    0, 
                    "#9e0142"
                ], 
                [
                    0.1, 
                    "#d53e4f"
                ], 
                [
                    0.2, 
                    "#f46d43"
                ], 
                [
                    0.3, 
                    "#fdae61"
                ], 
                [
                    0.4, 
                    "#fee08b"
                ], 
                [
                    0.5, 
                    "#ffffbf"
                ], 
                [
                    0.6, 
                    "#e6f598"
                ], 
                [
                    0.7, 
                    "#abdda4"
                ], 
                [
                    0.8, 
                    "#66c2a5"
                ], 
                [
                    0.9, 
                    "#3288bd"
                ], 
                [
                    1, 
                    "#5e4fa2"
                ]
            ], 
            "zsrc": "peromage:5:2a5a85,a5bde7", 
            "ysrc": "peromage:5:c771cc", 
            "xsrc": "peromage:5:c8330a", 
            "colorbar": {
                "yanchor": "middle", 
                "tickwidth": 1, 
                "title": {
                    "text": "<br>"
                }, 
                "xanchor": "left", 
                "ticks": "inside", 
                "thickness": 20, 
                "borderwidth": 0, 
                "y": 0.5, 
                "x": 1, 
                "outlinewidth": 0, 
                "exponentformat": "000"
            }, 
            "cauto": true, 
            "lighting": {
                "roughness": 0.5, 
                "fresnel": 0.25, 
                "specular": 0.2, 
                "diffuse": 0.8, 
                "ambient": 0.9
            }, 
            "mode": "markers", 
            "hoverinfo": "x+y+z", 
            "y": [
                "10", 
                "20", 
                30, 
                40, 
                50, 
                60, 
                70, 
                80
            ], 
            "x": [
                "2000", 
                "4000"
            ], 
            "z": [
                [
                    "5.902758421", 
                    "6.824057515"
                ], 
                [
                    "22.38897541", 
                    "23.49670836"
                ], 
                [
                    "49.77155205", 
                    "51.04671488"
                ], 
                [
                    "86.92171674", 
                    "89.25636856"
                ], 
                [
                    "134.6223837", 
                    "136.5094684"
                ], 
                [
                    "195.6309218", 
                    "197.979733"
                ], 
                [
                    "266.5006352", 
                    "269.0392752"
                ], 
                [
                    "349.0449253", 
                    "352.5316837"
                ]
            ], 
            "type": "surface"
        }
    ]
    }
    return figure;
}