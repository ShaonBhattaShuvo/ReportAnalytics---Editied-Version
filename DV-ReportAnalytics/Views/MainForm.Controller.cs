using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    partial class MainForm: IMainForm
    {
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }

        public void OpenFileHandler(object sender, OpenFileEventArgs args)
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
    }
}
