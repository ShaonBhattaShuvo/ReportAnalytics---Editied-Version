using System;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Controllers;
using SpreadsheetGear.Windows.Forms;

// this part implements the public methods that the controllers can use
namespace DV_ReportAnalytics.Views
{
    internal partial class MainForm : IMainForm
    {
        // ------ fileds ------
        private IMainFormController _controller;
        private bool _tableButtonEnabled;

        // ------ properties ------
        public WorkbookView WorkbookView { get { return workbookView; } }
        public OpenFileDialog OpenFileDialog { get { return openFileDialog; } }
        public SaveFileDialog SaveFileDialog { get { return saveFileDialog; } }
        public bool EnableTableButtons
        {
            get { return _tableButtonEnabled; }
            set
            {
                _tableButtonEnabled = value;
                toolStripButtonTableDisplay.Enabled = _tableButtonEnabled;
                toolStripButtonGraphToggle.Enabled = _tableButtonEnabled;
            }
        }

        // ------ public ------
        private void _Initialize()
        {
            // bind controllers and models
            _controller = new MainFormController(this);
            _controller.UserMessageUpdated += _UserMessageUpdated;
        }

        // ------ private ------

        private void _UserMessageUpdated(object sender, UserMessageEventArgs args)
        {
            MessageBox.Show(args.Message);
        }
    }
}