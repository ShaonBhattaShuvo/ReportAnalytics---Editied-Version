using System;
using System.Xml;
using System.IO;

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
            InitializeBindings();
            InitializeClass();
        }

        private void InitializeModel()
        {
            // avoid multiple instances being initiated
            ModelTypes t = _doc.GetNodeValue("Settings/Type").ToModelTypes();
            string p = _doc.GetNodeValue("Paths/Result");
            switch (t)
            {
                case ModelTypes.EPTReport:
                    testcode(p);
                    break;
                default:
                    break;
            }
        }

        private void InitializeClass()
        {
        }

        private void testcode(string p)
        {
            // TODO: this is test code. it will be removed in the future
            XmlDocument display = new XmlDocument();
            display.LoadXml(Properties.Resources.Displays_EPTReport);
            _doc.UpdateNode(display, "Displays");
            string cache = Path.GetTempFileName();
            File.Copy(p, cache, true);
            EPTModel model = new EPTModel();
            model.WorkbookUpdated += (object sender, WorkbookUpdateEventArgs e) =>
            {
                _mainForm.WorkbookView.ActiveWorkbook = e.Workbook;
                _mainForm.Chrome.Load("file:///surfaces.html");
            };
            model.Build(cache, _doc);
            model.Draw(cache, _doc);
        }
    }
}
