using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Extensions;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views.ProcessPanels
{
    internal partial class EPTProcessPanel : UserControl, IBaseControl
    {
        public event Action<object, FormUpdateEventArgs> ContentUpdated;

        public XmlDocument Content
        {
            set
            {
                textBoxType.Text = value.GetNodeValue("Type");
                textBoxName.Text = value.GetNodeValue("Name");
                textBoxInputSheetName.Text = value.GetNodeValue("InputSheetName");
                textBoxOutputSheetName.Text = value.GetNodeValue("OutputSheetName");
                textBoxParameter.Text = value.GetNodeValue("ResultFormat/Text");
                textBoxDelimiter.Text = value.GetNodeValue("ResultFormat/Delimiter");
                numericUpDownParameterColumn.Value = value.GetNodeValue<decimal>("ResultFormat/TextColumn");
                numericUpDownValueColumn.Value = value.GetNodeValue<decimal>("ResultFormat/ValueColumn");
            }
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.Load(Properties.Resources.Settings_EPTReport);
                doc.SetNodeValue("Type", textBoxType.Text);
                doc.SetNodeValue("Name", textBoxName.Text);
                doc.SetNodeValue("InputSheetName", textBoxInputSheetName.Text);
                doc.SetNodeValue("OutputSheetName", textBoxOutputSheetName.Text);
                doc.SetNodeValue("ResultFormat/Text", textBoxParameter.Text);
                doc.SetNodeValue("ResultFormat/Delimiter", textBoxDelimiter.Text);
                doc.SetNodeValue("ResultFormat/TextColumn", numericUpDownParameterColumn.Value);
                doc.SetNodeValue("ResultFormat/ValueColumn", numericUpDownValueColumn.Value);
                return doc;
            }
        }

        public EPTProcessPanel()
        {
            InitializeComponent();
            BindEvents();
        }

        private void BindEvents()
        {
            textBoxType.TextChanged += (object sender, EventArgs e) => UpdateContents();
            textBoxName.TextChanged += (object sender, EventArgs e) => UpdateContents();
            textBoxInputSheetName.TextChanged += (object sender, EventArgs e) => UpdateContents();
            textBoxOutputSheetName.TextChanged += (object sender, EventArgs e) => UpdateContents();
            textBoxParameter.TextChanged += (object sender, EventArgs e) => UpdateContents();
            textBoxDelimiter.TextChanged += (object sender, EventArgs e) => UpdateContents();
            numericUpDownParameterColumn.ValueChanged += (object sender, EventArgs e) => UpdateContents();
            numericUpDownValueColumn.ValueChanged += (object sender, EventArgs e) => UpdateContents();
        }

        private void UpdateContents()
        {
            ContentUpdated?.Invoke(this, new FormUpdateEventArgs(Content));
        }
    }
}
