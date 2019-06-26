using System;
using System.Windows.Forms;
using SpreadsheetGear.Windows.Forms;
using CefSharp.WinForms;

namespace DV_ReportAnalytics.UI
{
    internal partial class MainForm : Form
    {
        #region Properties and fields
        public ToolStripButton ButtonOpenFile { get { return toolStripButtonOpenFile; } }
        public ToolStripButton ButtonSaveFile { get { return toolStripButtonSaveFile; } }
        public ToolStripButton ButtonSettings { get { return toolStripButtonSettings; } }
        public ToolStripButton ButtonTableDisplay { get { return toolStripButtonTableDisplay; } }
        public ToolStripButton ButtonGraphToggle { get { return toolStripButtonGraphToggle; } }
        public ToolStripButton ButtonHelp { get { return toolStripButtonHelp; } }
        public SplitContainer SplitContainer { get { return splitContainerMain; } }
        public WorkbookView WorkbookView { get { return workbookView; } }
        private MainFormPresenter _mainPresenter;
        private ChromiumWebBrowser _chrome;
        public ChromiumWebBrowser Chrome { get { return _chrome; } }
        #endregion

        #region Methods
        public MainForm()
        {
            InitializeComponent();
            _mainPresenter = new MainFormPresenter(this);
            _chrome = new ChromiumWebBrowser("www.google.com")
            {
                Dock = DockStyle.Fill
            };
            splitContainerMain.Panel2.Controls.Add(_chrome);
        }
        #endregion
    }
}
