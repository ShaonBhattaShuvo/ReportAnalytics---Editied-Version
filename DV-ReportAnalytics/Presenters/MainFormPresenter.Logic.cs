using System;

namespace DV_ReportAnalytics.UI
{
    internal partial class MainFormPresenter
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
