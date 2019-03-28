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
            // TODO: Create all necessary classes which require different functionality from MainForm
        }

        public void AppForm_OpenButtonClicked()
        {
            OpenFileDialog ofd = _mainForm.OpenFileDialog;
            // open window to select file
            if (ofd.ShowDialog() == DialogResult.OK)
                _OpenWorkbookView(ofd.FileName);

            // after file being selected open window to ocnfigure process parameter
            AppForm_SettingsButtonClicked();
        }

        public void AppForm_SaveButtonClicked()
        {
            SaveFileDialog sfd = _mainForm.SaveFileDialog;
            // open window to select saving location
            if (sfd.ShowDialog() == DialogResult.OK)
                _mainForm.WorkbookView.ActiveWorkbook.SaveAs(sfd.FileName, SpreadsheetGear.FileFormat.OpenXMLWorkbook);

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
            _processConfigForm.Show();
        }

        public void AppForm_HelpInfoButtonClicked()
        {
            _UserMessageUpdated(this, new UserMessageEventArgs("Implement Help/Info."));
        }

        // ------ private ------
        private void _ProcessConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {
            // TODO: pass config to model
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
