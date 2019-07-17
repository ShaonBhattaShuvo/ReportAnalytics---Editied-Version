﻿using System;
using System.Windows.Forms;
using System.Xml;

namespace DV_ReportAnalytics.UI
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
                textBoxParameter.Text = value.GetNodeValue("Settings/ResultFormat/Parameter");
                textBoxDelimiter.Text = value.GetNodeValue("Settings/ResultFormat/Delimiter");
                textBoxParameterColumn.Text = value.GetNodeValue("Settings/ResultFormat/ParameterColumn");
                textBoxValueColumn.Text = value.GetNodeValue("Settings/ResultFormat/ValueColumn");
            }
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Properties.Resources.Settings_EPTReport);
                doc.SetNodeValue("Settings/Type", textBoxType.Text);
                doc.SetNodeValue("Settings/Name", textBoxName.Text);
                doc.SetNodeValue("Settings/InputSheetName", textBoxInputSheetName.Text);
                doc.SetNodeValue("Settings/OutputSheetName", textBoxOutputSheetName.Text);
                doc.SetNodeValue("Settings/ResultFormat/Parameter", textBoxParameter.Text);
                doc.SetNodeValue("Settings/ResultFormat/Delimiter", textBoxDelimiter.Text);
                doc.SetNodeValue("Settings/ResultFormat/ParameterColumn", textBoxParameterColumn.Text);
                doc.SetNodeValue("Settings/ResultFormat/ValueColumn", textBoxValueColumn.Text);
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
            textBoxParameterColumn.TextChanged += (object sender, EventArgs e) => UpdateContents();
            textBoxValueColumn.TextChanged += (object sender, EventArgs e) => UpdateContents();
        }

        private void UpdateContents()
        {
            ContentUpdated?.Invoke(this, new ContentUpdateEventArgs(Content, "Settings"));
        }
    }
}