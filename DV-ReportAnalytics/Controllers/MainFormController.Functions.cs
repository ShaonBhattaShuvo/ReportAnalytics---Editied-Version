using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.Models;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Constant;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Controllers
{
    partial class MainFormController : IMainFormController
    {
        private IMainForm _view;
        private ISpreadSheetModel _model;
        public event UserMessageEventHandler UserMessageUpdated = null;
        public event FileOpenEventHandler FileOpen;

        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            if (UserMessageUpdated != null)
                UserMessageUpdated.Invoke(sender, args);
        }

        private void _FileOpen(object sender, FileOpenEventArgs args)
        {
            if (FileOpen != null)
                FileOpen.Invoke(sender, args); // update observer
        }

        private void _GetModel(string type, string path)
        {

            if (Enum.TryParse<ModelTypes>(type, false, out ModelTypes t))
            {
                switch (t)
                {
                    case ModelTypes.EptReport:
                        // do something
                        _model = new EptReportModel(path);
                        break;
                    default:
                        break;

                }
            }
            else
            {
                // throw exception
            }
        }
    }
}
