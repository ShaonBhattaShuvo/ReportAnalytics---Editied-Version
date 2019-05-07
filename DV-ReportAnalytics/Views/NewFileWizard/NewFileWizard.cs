using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DV_ReportAnalytics.Views
{
    internal partial class NewFileWizard : Form, INewFileWizard
    {
        private UserControl[] _pages;
        private int _index;
        private int _maxIndex;

        public NewFileWizard()
        {
            InitializeComponent();
            _pages = new UserControl[]
            {
                new NewFileWizardPage1(),
                new NewFileWizardPage2()
            };
            _index = 0;
            _maxIndex = _pages.Length - 1;
            RefreshPage();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (_index == 0)
                return;
            else
            {
                _index -= 1;
                RefreshPage();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_index == _maxIndex)
                return;
            else
            {
                _index += 1;
                RefreshPage();
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshPage()
        {
            _pages[_index].Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(_pages[_index]);
            _pages[_index].Show();
            buttonBack.Enabled = !(_index <= 0);
            buttonNext.Enabled = !(_index >= _maxIndex);
        }
    }
}
