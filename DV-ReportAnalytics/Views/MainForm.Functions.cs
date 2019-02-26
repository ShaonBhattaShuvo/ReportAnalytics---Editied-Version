using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Models;
using SpreadsheetGear;

// this part implements the public methods that the controllers can use
namespace DV_ReportAnalytics.Views
{
    partial class MainForm: IMainForm
    {
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }

        private void _FileOpen(object sender, FileOpenEventArgs args)
        {
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            workbookView.GetLock();
            workbookView.Visible = true;
            try
            {
                // close previous before open a new file
                workbookView.ActiveWorkbookSet.Workbooks.Close();
                workbookView.ActiveWorkbook = workbookView.ActiveWorkbookSet.Workbooks.Open(args.Path);
                printAllWorkbooks();
            }
            finally
            {
                workbookView.ReleaseLock();
            }

        }

        private void printAllWorkbooks()
        {
            IWorkbooks wbs = workbookView.ActiveWorkbookSet.Workbooks;
            Console.WriteLine("--------begin------------");
            for (int i = 0; i < wbs.Count; i++)
            {
                Console.WriteLine(wbs[i].FullName);
            }
            Console.WriteLine("---------end-------------");
        }

        public void SetModel(ISpreadSheetModel model)
        {
            // model that view observes
            _model = model; 
        }
    }
}
