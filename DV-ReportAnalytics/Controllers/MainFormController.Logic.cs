using System;

namespace DV_ReportAnalytics
{
    internal partial class MainFormController
    {
        private void InitializeModel()
        {
            // avoid multiple instances being initiated
            ModelTypes t = _doc.GetNodeValue("Settings/Type").ToModelTypes();
            string p = _doc.GetNodeValue("Paths/Result");
            switch (t)
            {
                case ModelTypes.EPTReport:
                    model = new EPTModel(_doc);

                    break;
                default:
                    break;
            }
        }

    }
}
