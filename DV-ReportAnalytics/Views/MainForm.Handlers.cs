using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    partial class MainForm
    {
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }
        
        private void _OpenDialogHandler(object sender, EventArgs args)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set model file path
                _spreadSheetModel.setFilePath(openFileDialog.FileName);
            }
        }

        private void _OpenFileHandler(object sender, OpenFileEventArgs args)
        {
            // open file in window
            spreadSheetContainer.Navigate(args.Path, false);
        }
    }
}
