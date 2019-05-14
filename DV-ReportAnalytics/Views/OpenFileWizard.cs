using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views
{
    internal partial class OpenFileWizard : Form
    {
        #region Properties and fields
        public Button ButtonBack { get { return buttonBack; } }
        public Button ButtonNext { get { return buttonNext; } }
        public Button ButtonFinish { get { return buttonFinish; } }
        public IWizardPage[] Pages { get; }
        #endregion

        #region Events
        public event Action<object, FormUpdateEventArgs> WizardFinished;
        #endregion

        private IWizardPage[] _pages;
        private int _index;
        private XmlDocument[] _pageDocs; // contains config for each page
        private const int _PAGES = 2; // page number

        public OpenFileWizard()
        {
            InitializeComponent();
            _pages = new IWizardPage[]
            {
                new OpenFileWizardPage1(),
                new OpenFileWizardPage2()
            };
            // register page info
            for (int i = 0; i < _PAGES; i++)
            {
                _pages[i].WizardPageReady += PageUpdate;
                _pages[i].Dock = DockStyle.Fill;
            }
            _pageDocs = new XmlDocument[_PAGES];
            _index = 0;
            RefreshPage(0);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _pageDocs[_index] = _pages[_index].Submit();
            RefreshPage(-1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _pageDocs[_index] = _pages[_index].Submit();
            RefreshPage(1);
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            // default action
            for (int i = 0; i < _PAGES; i++)
            {
                if (_pageDocs[i] == null)
                {
                    _pages[i].Reload(_pageDocs);
                    _pageDocs[i] = _pages[i].Submit();
                }
            }
            if (WizardFinish != null)
                WizardFinish.Invoke(this, new WizardFinishEventArgs(_pageDocs, true));

            Close();
        }

        private void RefreshPage(int step)
        {
            _index += step;
            // reload configs from previous pages
            if (step == 1)
                _pages[_index].Reload(_pageDocs);

            panelContent.Controls.Clear();
            panelContent.Controls.Add((UserControl)_pages[_index]);
            _pages[_index].Show();
            // button control
            buttonEnable();
        }

        private void buttonEnable()
        {
            buttonBack.Enabled = !(_index <= 0);
            buttonNext.Enabled = (_index < _PAGES - 1) && (_pages[_index].Ready);
            buttonFinish.Enabled = _pages[0].Ready;
        }

        private void PageUpdate(object sender, WizardPageReadyEventArgs e)
        {
            if (sender == _pages[0] && e.OK)
                buttonEnable();
        }
    }
}
