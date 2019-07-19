﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IViewsProviders
    {
        IEPTViewsProvider EPTViewsProvider { get; }
        IWizardViewsProvider WizardViewsProvider { get; }
        IMainViewsProvider MainViewsProvider { get; }
    }
}
