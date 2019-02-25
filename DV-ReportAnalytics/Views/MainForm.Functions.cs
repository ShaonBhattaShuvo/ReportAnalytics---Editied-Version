using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Models;

// this part implements the public methods that the controllers can use
namespace DV_ReportAnalytics.Views
{
    partial class MainForm: IMainForm
    {
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }

        private void _ShowFileHandler(object sender, FileOpenEventArgs args)
        {
            // open file in window
            spreadSheetContainer.Navigate(args.Path, false);
        }

        public void SetModel(ISpreadSheetModel model)
        {
            // model that view observes
            _model = model; 
            // and bind events
            _model.FileOpen += _ShowFileHandler;
        }
    }
}
