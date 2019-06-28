﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.App
{
    public interface IView
    {
        event EventHandler RequestClosed;
        void Close();
        void Show();
    }
}
