using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;
using SpreadsheetGear;
using SpreadsheetGear.Windows.Forms;

// this part implements the public methods that the controllers can use
namespace DV_ReportAnalytics.Views
{
    internal partial class MainForm : IMainForm
    {
        // ------ properties ------
        public WorkbookView WorkbookView { get { return workbookView; } }
        public OpenFileDialog OpenFileDialog { get { return openFileDialog; } }
        public SaveFileDialog SaveFileDialog { get { return saveFileDialog; } }

        // ------ public ------


        // ------ private ------

        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }
    }
}