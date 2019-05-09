using System;
using System.ComponentModel;
using System.Windows.Forms;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views.Components
{
    internal partial class FileBrowserWithLabel : UserControl
    {
        [Category("Settings"), Description("Path is readonly.")]
        public string Path
        {
            private set { textBox.Text = value; }
            get { return textBox.Text; }
        }
        [Category("Settings"), Description("Description for this section.")]
        public string Description
        {
            set { label.Text = value; }
            get { return label.Text; }
        }
        [Category("Settings"), Description("Browser filter.")]
        public string Filter
        {
            set { openFileDialog.Filter = value; }
            get { return openFileDialog.Filter; }
        }

        public event FileBrowserWithLabelUpdateEventHandler FileBrowserWithLabelUpdate;

        public FileBrowserWithLabel()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
                textBox.Text = Path;
                if (FileBrowserWithLabelUpdate != null)
                    FileBrowserWithLabelUpdate.Invoke(this, new FileBrowserWithLabelUpdateEventArgs(Path, true));
            }
        }
    }
}
