using System;
using System.Xml;
using DV_ReportAnalytics.Constant;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Views;
using SpreadsheetGear;
using SpreadsheetGear.Windows.Forms;

namespace DV_ReportAnalytics.Controllers
{
    internal partial class MainFormController : IMainFormController
    {
        private IMainForm _mainForm;
        private IWorkbookModelController _workbookModelController;
        private IProcessConfigForm _processConfigForm;
        public event UserMessageEventHandler UserMessageUpdated = null;
        private XmlDocument _processConfig;
        private ModelTypes _currentModel;

        // ------public------


        // ------private------
        private void InitModelController()
        {
            // TODO: change type dynamically
            //string type = _processConfig.GetNodeValue("Type");
            string type = "EPTReport";
            // convert string to corresponding type
            if (Enum.TryParse<ModelTypes>(type, false, out ModelTypes t))
            {
                // avoid multiple instances being initiated
                if (_currentModel != t)
                {
                    // new type initiated
                    _currentModel = t;
                    switch (_currentModel)
                    {
                        case ModelTypes.EPTReport:
                            _workbookModelController = new EptReportController(_mainForm);
                            break;
                        default:
                            break;
                    }
                }
                //_workbookModelController.SetProcessConfig(_processConfig);
            }
            else
            {
                throw new Exception("Invalid type!");
            }
        }

        // process config window event call back
        private void ProcessConfigUpdated(object sender, WorkbookConfigUpdateEventArgs e)
        {
            //_processConfig = e.Config;
            InitModelController();
        }

        private bool OpenWorkbookView(string path)
        {
            WorkbookView wbv = _mainForm.WorkbookView;
            bool success;
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            wbv.GetLock();
            try
            {
                // close previous before open a new file
                wbv.ActiveWorkbook.Close();
                wbv.ActiveWorkbook = wbv.ActiveWorkbookSet.Workbooks.Open(path);
                wbv.Visible = true;
                success = true;
                //printAllWorkbooks();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = false;
            }
            finally
            {
                wbv.ReleaseLock();
            }
            return success;
        }

        private bool SaveWorkbookView(string path)
        {
            WorkbookView wbv = _mainForm.WorkbookView;
            bool success;
            // Interrupt background calculation if necessary and acquire a lock on the workbook set.
            wbv.GetLock();
            try
            {
                wbv.ActiveWorkbook.SaveAs(path, SpreadsheetGear.FileFormat.OpenXMLWorkbook);
                success = true;
                //PrintAllWorkbooks();
            }
            catch (Exception e)
            {
                success = false;
            }
            finally
            {
                wbv.ReleaseLock();
            }
            return success;
        }

        private void PrintAllWorkbooks()
        {
            IWorkbooks wbs = _mainForm.WorkbookView.ActiveWorkbookSet.Workbooks;
            Console.WriteLine("--------WorkbookView Items------------");
            for (int i = 0; i < wbs.Count; i++)
            {
                Console.WriteLine(wbs[i].FullName);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
