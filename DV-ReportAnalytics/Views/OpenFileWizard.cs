using System;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal partial class OpenFileWizard : Form
    {
        #region Properties and fields
        public Button ButtonBack { get { return buttonBack; } }
        public Button ButtonNext { get { return buttonNext; } }
        public Button ButtonFinish { get { return buttonFinish; } }
        public Panel PanelContent { get { return panelContent; } }
        public IBaseControl[] Pages { get; }
        #endregion

        #region Events
        public event Action<object, ContentUpdateEventArgs> WizardFinished;
        #endregion

        public OpenFileWizard()
        {
            InitializeComponent();

            Pages = new IBaseControl[]
            {
                new PathControl() { Dock = DockStyle.Fill }, // page 1
                new SettingsControl() { Dock = DockStyle.Fill } // page 2
            };
        }
    }
}
