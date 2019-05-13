﻿using System;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Constants;


namespace DV_ReportAnalytics.Controllers
{
    internal partial class MainFormController
    {
        private MainForm _mainForm;
        private ModelTypes _currentModel;
        
        public MainFormController(MainForm mainForm)
        {
            // mainform should be binded with controller here
            _mainForm = mainForm;
            _currentModel = ModelTypes.None;
            InitializeClass();
        }
    }
}
