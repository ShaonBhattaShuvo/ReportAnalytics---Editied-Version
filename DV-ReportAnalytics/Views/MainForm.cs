using System;
using System.Windows.Forms;

namespace DV_ReportAnalytics
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
        private MainFormController _mainController;
        #endregion

        #region Methods
        public MainForm()
        {
            InitializeComponent();
            _mainController = new MainFormController(this);
        }
        #endregion
    }
}
