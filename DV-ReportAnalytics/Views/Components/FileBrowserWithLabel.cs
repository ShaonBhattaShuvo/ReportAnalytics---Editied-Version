using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DV_ReportAnalytics.Views
{
    public partial class FileBrowserWithLabel : UserControl
    {
        public string Path { private set; get; }

        public FileBrowserWithLabel(string title, string filter)
        {
            InitializeComponent();
            label.Text = title;
            openFileDialog.Filter = filter;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
                textBox.Text = Path;
            }
        }
    }
}
