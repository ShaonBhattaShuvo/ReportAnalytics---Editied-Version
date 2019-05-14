using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.Models
{
    internal interface IReportModel
    {
        void Load();
        void Reload();
        void ChangeView();
        void Save();
        event EventHandler ModelUpdated;
    }
}
