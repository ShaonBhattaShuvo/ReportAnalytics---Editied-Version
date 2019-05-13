using System;
using System.Windows.Forms;
using DV_ReportAnalytics.Controllers;

namespace DV_ReportAnalytics.Views
{
    /// <summary>
    /// Do not touch this file. All the coding must be done in UIController.cs
    /// </summary>
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
