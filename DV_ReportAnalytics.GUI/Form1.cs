using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace DV_ReportAnalytics.GUI
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser chrome;
        public Form1()
        {
            InitializeComponent();
            chrome = new ChromiumWebBrowser("www.google.com")
            {
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(chrome);
        }
    }
}
