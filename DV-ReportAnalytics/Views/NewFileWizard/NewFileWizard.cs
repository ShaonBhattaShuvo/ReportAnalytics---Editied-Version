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
    internal partial class NewFileWizard : Form, INewFileWizard
    {
        public event WizardFinishEventHandler WizardFinish;

        private IWizardPage[] _pages;
        private int _index;
        private XmlDocument[] _pageDocs; // contains config for each page
        private const int _PAGES = 2; // page number

        public NewFileWizard()
        {
            InitializeComponent();
            _pages = new IWizardPage[]
            {
                new NewFileWizardPage1(),
                new NewFileWizardPage2()
            };
            // register page info
            for (int i = 0; i < _PAGES; i++)
            {
                _pages[i].WizardPageReady += PageUpdate;
                _pages[i].Dock = DockStyle.Fill;
            }
            _pageDocs = new XmlDocument[_PAGES];
            _index = 0;
            RefreshPage();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _pageDocs[_index] = _pages[_index].Submit();
            _index -= 1;
            RefreshPage();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _pageDocs[_index] = _pages[_index].Submit();
            _index += 1;
            RefreshPage();
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

        private void RefreshPage()
        {
            // reload configs from previous pages
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
            buttonNext.Enabled = (_index < _PAGES) && (_pages[_index].Ready);
            buttonFinish.Enabled = _pages[0].Ready;
        }

        private void PageUpdate(object sender, WizardPageReadyEventArgs e)
        {
            if (sender == _pages[0] && e.OK)
                buttonEnable();
        }
    }
}
