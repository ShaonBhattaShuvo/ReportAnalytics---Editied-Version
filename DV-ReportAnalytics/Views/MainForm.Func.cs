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
        public WorkbookView WorkbookView
        {
            get
            {
                return workbookView;
            }
        }
        // ------ public ------

        public void OpenWorkbookView(byte[] buffer)
        {
            UpdateWorkbookView(buffer);
        }

        public void UpdateWorkbookView(byte[] buffer)
        {
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            workbookView.GetLock();
            try
            {
                workbookView.Visible = false;
                // close previous before open a new file
                workbookView.ActiveWorkbook.Close();
                workbookView.ActiveWorkbook = workbookView.ActiveWorkbookSet.Workbooks.OpenFromMemory(buffer);
                workbookView.Visible = true;
                //printAllWorkbooks();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                workbookView.ReleaseLock();
            }
        }

        // ------ private ------

        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }

        private void printAllWorkbooks()
        {
            IWorkbooks wbs = workbookView.ActiveWorkbookSet.Workbooks;
            Console.WriteLine("--------WorkbookView Items------------");
            for (int i = 0; i < wbs.Count; i++)
            {
                Console.WriteLine(wbs[i].FullName);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}