using System;
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
        private XmlDocument _doc;
        
        public MainFormController(MainForm mainForm)
        {
            // mainform should be binded with controller here
            _mainForm = mainForm;
            InitializeClass();
        }
    }
}
