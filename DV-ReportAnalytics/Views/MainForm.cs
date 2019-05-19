using System;
using System.Windows.Forms;
using SpreadsheetGear.Windows.Forms;

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
        #endregion

        #region Methods
        public MainForm()
        {
            InitializeComponent();
            _mainPresenter = new MainFormPresenter(this);
        }
        #endregion
    }
}
