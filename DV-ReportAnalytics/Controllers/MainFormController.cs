using System;
using System.Xml;

namespace DV_ReportAnalytics
{
    internal partial class MainFormController
    {
        private MainForm _mainForm;
        private XmlDocument _doc;

        public MainFormController(MainForm mainForm)
        {
            // mainform should be binded with controller here
            _mainForm = mainForm;
            InitializeClass();
        }
    }
}
