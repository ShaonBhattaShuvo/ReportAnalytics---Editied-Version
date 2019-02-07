using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Models;

namespace DV_ReportAnalytics.Views
{
    public partial class MainForm: IMainForm
    {
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }

        private void _ShowFileHandler(object sender, ShowFileEventArgs args)
        {
            // open file in window
            spreadSheetContainer.Navigate(args.Path, false);
        }

        public string GetPathFromDialog()
        {
            string filename = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set model file path
                filename = openFileDialog.FileName;
            }
            return filename;   
        }

        public void SetModel(ISpreadSheetModel model)
        {
            _model = model;
            _model.ShowFile += _ShowFileHandler; // and bind it with mainform
        }
    }
}
