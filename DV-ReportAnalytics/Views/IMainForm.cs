using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Views
{
    public interface IMainForm
    {
        string GetPathFromDialog();
        void SetModel(ISpreadSheetModel model);
    }
}
