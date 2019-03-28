using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Constant;
using SpreadsheetGear;
using SpreadsheetGear.Windows.Forms;


namespace DV_ReportAnalytics.Controllers
{
    /// <summary>
    /// Place your code here
    /// </summary>
    internal partial class MainFormController: IMainFormController
    {
        private IMainForm _mainForm;
        private IWorkbookModelController _workbookModelController;
        private IProcessConfigForm _processConfigForm;
        public event UserMessageEventHandler UserMessageUpdated = null;
        private XmlDocument _processConfig;
        private ModelTypes _currentModel;

        // ------ public ------
        public MainFormController(IMainForm mainForm)
        {
            // mainform should be binded with controller here
            _mainForm = mainForm;
            _currentModel = ModelTypes.None;
        }

        public void AppForm_OpenButtonClicked()
        {
            OpenFileDialog ofd = _mainForm.OpenFileDialog;
            // open window to select file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // after file being selected open window to ocnfigure process parameter
                AppForm_SettingsButtonClicked();
                _OpenWorkbookView(ofd.FileName);
                _mainForm.EnableTableButtons = true;
            }
        }

        public void AppForm_SaveButtonClicked()
        {
            SaveFileDialog sfd = _mainForm.SaveFileDialog;
            // open window to select saving location
            if (sfd.ShowDialog() == DialogResult.OK)
                _SaveWorkbookView(sfd.FileName);
        }

        public void AppForm_TableButtonClicked()
        {
            _workbookModelController.ShowModelView();
        }

        public void AppForm_GraphButtonClicked()
        {
            
        }

        public void AppForm_SettingsButtonClicked()
        {
            _processConfigForm = new ProcessConfigForm();
            _processConfigForm.WorkbookConfigUpdate += _ProcessConfigUpdated;
            _processConfigForm.ShowDialog();
        }

        public void AppForm_HelpInfoButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Implement Help/Info."));
        }

        // ------ private ------
        // process config window event call back
        private void _ProcessConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {
            _processConfig = e.Config;
            _InitModelController();
        }

        private void _OpenWorkbookView(string path)
        {
            WorkbookView wbv = _mainForm.WorkbookView;
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            wbv.GetLock();
            try
            {
                // close previous before open a new file
                wbv.ActiveWorkbook.Close();
                wbv.ActiveWorkbook = wbv.ActiveWorkbookSet.Workbooks.Open(path);
                wbv.Visible = true;
                //printAllWorkbooks();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                wbv.ReleaseLock();
            }
        }

        private void _SaveWorkbookView(string path)
        {
            WorkbookView wbv = _mainForm.WorkbookView;
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            wbv.GetLock();
            try
            {
                wbv.ActiveWorkbook.SaveAs(path, SpreadsheetGear.FileFormat.OpenXMLWorkbook);
                //printAllWorkbooks();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                wbv.ReleaseLock();
            }
        }

        private void printAllWorkbooks()
        {
            IWorkbooks wbs = _mainForm.WorkbookView.ActiveWorkbookSet.Workbooks;
            Console.WriteLine("--------WorkbookView Items------------");
            for (int i = 0; i < wbs.Count; i++)
            {
                Console.WriteLine(wbs[i].FullName);
            }
            Console.WriteLine("--------------------------------------");
        }

        // TODO: remove them?
        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            if (UserMessageUpdated != null)
                UserMessageUpdated.Invoke(sender, args);
        }
    }
}
