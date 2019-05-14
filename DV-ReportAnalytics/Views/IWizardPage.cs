using System;
using System.Xml;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal interface IWizardPage
    {
        int PageNumber { get; }
    }
}
