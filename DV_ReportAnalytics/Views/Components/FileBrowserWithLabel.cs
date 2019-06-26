using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace DV_ReportAnalytics.UI
{
    internal partial class FileBrowserWithLabel : UserControl, IBaseControl
    {
        [Category("Settings"), Description("Path is readonly.")]
        public string Path
        {
            set { textBox.Text = value; }
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

        [Category("Settings"), Description("Browser filter.")]
        public bool EnableTextBox
        {
            set { textBox.Enabled = value; }
            get { return textBox.Enabled; }
        }

        public XmlDocument Content { set; get; }

        public event Action<object, ContentUpdateEventArgs> ContentUpdated;

        public FileBrowserWithLabel()
        {
            InitializeComponent();
            // change event binding if validation needed
            textBox.TextChanged +=
                (object sender, EventArgs e) => ContentUpdated?.Invoke(this, new ContentUpdateEventArgs(Path));
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                Path = openFileDialog.FileName;
        }
    }
}
