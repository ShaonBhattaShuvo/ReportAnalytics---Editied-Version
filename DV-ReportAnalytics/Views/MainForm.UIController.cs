using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics
{
    partial class MainForm
    {
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }
        
        private void _OpenFile(object sender, OpenFileEventArgs args)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                spreadSheetContainer.Navigate(openFileDialog.FileName, false);
            }
        }
    }
}
