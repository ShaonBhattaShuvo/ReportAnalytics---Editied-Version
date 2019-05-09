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

namespace DV_ReportAnalytics.Views.ProcessPanels
{
    internal partial class EPTProcessPanel : UserControl, IProcessPanel
    {
        public EPTProcessPanel()
        {
            InitializeComponent();
        }

        public XmlDocument Submit()
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load(Properties.Resources.ConfigurationTemplate_EPTReport);
            doc.SetNodeValue("Name", textBoxName.Text);
            doc.SetNodeValue("InputSheetName", textBoxInputSheetName.Text);
            doc.SetNodeValue("OutputSheetName", textBoxOutputSheetName.Text);
            doc.SetNodeValue("ResultFormat/Text", textBoxText.Text);
            doc.SetNodeValue("ResultFormat/Delimiter", textBoxDelimiter.Text);
            doc.SetNodeValue("ResultFormat/TextColumn", numericUpDownTextColumn.Value);
            doc.SetNodeValue("ResultFormat/ValueColumn", numericUpDownValueColumn.Value);
            return doc;
        }

        public void Reload(XmlDocument doc)
        {
            textBoxName.Text = doc.GetNodeValue("Name");
            textBoxInputSheetName.Text = doc.GetNodeValue("InputSheetName");
            textBoxOutputSheetName.Text = doc.GetNodeValue("OutputSheetName");
            textBoxText.Text = doc.GetNodeValue("ResultFormat/Text");
            textBoxDelimiter.Text = doc.GetNodeValue("ResultFormat/Delimiter");
            numericUpDownTextColumn.Value = doc.GetNodeValue<decimal>("ResultFormat/TextColumn");
            numericUpDownValueColumn.Value = doc.GetNodeValue<decimal>("ResultFormat/ValueColumn");
        }
    }
}
