﻿using System;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Extensions;
using DV_ReportAnalytics.Events;

namespace DV_ReportAnalytics.Views.ProcessPanels
{
    internal partial class EPTProcessPanel : UserControl, IBaseControl
    {
        public event Action<object, ContentUpdateEventArgs> ContentUpdated;

        public XmlDocument Content
        {
            set
            {
                textBoxType.Text = value.GetNodeValue("Settings/Type");
                textBoxName.Text = value.GetNodeValue("Settings/Name");
                textBoxInputSheetName.Text = value.GetNodeValue("Settings/InputSheetName");
                textBoxOutputSheetName.Text = value.GetNodeValue("Settings/OutputSheetName");
                textBoxParameter.Text = value.GetNodeValue("Settings/ResultFormat/Text");
                textBoxDelimiter.Text = value.GetNodeValue("Settings/ResultFormat/Delimiter");
                numericUpDownParameterColumn.Value = value.GetNodeValue<decimal>("Settings/ResultFormat/TextColumn");
                numericUpDownValueColumn.Value = value.GetNodeValue<decimal>("Settings/ResultFormat/ValueColumn");
            }
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.LoadXml(Properties.Resources.Settings_EPTReport);
                doc.SetNodeValue("Settings/Type", textBoxType.Text);
                doc.SetNodeValue("Settings/Name", textBoxName.Text);
                doc.SetNodeValue("Settings/InputSheetName", textBoxInputSheetName.Text);
                doc.SetNodeValue("Settings/OutputSheetName", textBoxOutputSheetName.Text);
                doc.SetNodeValue("Settings/ResultFormat/Text", textBoxParameter.Text);
                doc.SetNodeValue("Settings/ResultFormat/Delimiter", textBoxDelimiter.Text);
                doc.SetNodeValue("Settings/ResultFormat/TextColumn", numericUpDownParameterColumn.Value);
                doc.SetNodeValue("Settings/ResultFormat/ValueColumn", numericUpDownValueColumn.Value);
                return doc;
            }
        }

        public EPTProcessPanel()
        {
            InitializeComponent();

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
            ContentUpdated?.Invoke(this, new ContentUpdateEventArgs(Content, "Settings"));
        }
    }
}