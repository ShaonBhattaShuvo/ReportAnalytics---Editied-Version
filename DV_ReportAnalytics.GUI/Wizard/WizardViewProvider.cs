using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public class WizardViewProvider : IWizardViewsProvider
    {
        public IWizardView CreateWizardView()
        {
            return new WizardView();
        }
    }
}
