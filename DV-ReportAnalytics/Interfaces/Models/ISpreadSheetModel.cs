﻿using System;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Models
{
    interface ISpreadSheetModel
    {
        string FileName {get;}
        string FilePath {get;}
        // event being triggered when file is open
        event FileOpenEventHandler FileOpen;
        // open file
        // FileOpen event should be triggered in this method
        void Open(); 
    }
}
