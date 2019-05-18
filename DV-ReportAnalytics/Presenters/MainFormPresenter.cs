using System;
using System.Xml;

namespace DV_ReportAnalytics.UI
{
    internal partial class MainFormPresenter
    {
        private MainForm _mainForm;
        private XmlDocument _doc;

        public MainFormPresenter(MainForm mainForm)
        {
            // mainform should be binded with controller here
            _mainForm = mainForm;
            InitializeClass();
        }
    }
}
