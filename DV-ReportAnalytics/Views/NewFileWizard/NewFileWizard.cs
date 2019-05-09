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
        public event NewFileWizardFinishEventHandler NewFileWizardFinish;

        private INewFileWizardPage[] _pages;
        private int _index;
        private XmlDocument[] _pageDocs; // contains config for each page
        private const int _PAGES = 2; // page number

        public NewFileWizard()
        {
            InitializeComponent();
            _pages = new INewFileWizardPage[]
            {
                new NewFileWizardPage1(),
                new NewFileWizardPage2()
            };
            // register page info
            for (int i = 0; i < _PAGES; i++)
            {
                _pages[i].NewFileWizardPageReady += PageUpdate;
                _pages[i].Dock = DockStyle.Fill;
            }
            _pageDocs = new XmlDocument[_PAGES];
            _index = 0;
            RefreshPage();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _index -= 1;
            RefreshPage();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _index += 1;
            RefreshPage();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
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
            buttonBack.Enabled = !(_index <= 0);
            buttonNext.Enabled = !(_index >= (_PAGES - 1));
        }

        private void PageUpdate(object sender, NewFileWizardPageReadyEventArgs e)
        {
            if (e.OK)
            {
                int pageNumber = ((INewFileWizardPage)sender).PageNumber;
                _pageDocs[pageNumber - 1] = e.Doc;
            }
            
        }
    }
}
