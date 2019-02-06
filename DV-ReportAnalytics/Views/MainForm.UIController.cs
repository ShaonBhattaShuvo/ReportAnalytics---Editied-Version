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
        
        private void _OnOpenFileHandler(object sender, EventArgs args)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _spreadSheetModel.setFilePath(openFileDialog.FileName);
            }
        }

        private void _OpenFileHandler(object sender, OpenFileEventArgs args)
        {
            spreadSheetContainer.Navigate(args.Path, false);
        }
    }
}
