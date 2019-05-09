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

namespace DV_ReportAnalytics.Views.ProcessPanels
{
    internal partial class EPTProcess : UserControl, IProcessPanel
    {
        public EPTProcess()
        {
            InitializeComponent();
        }

        public XmlDocument Submit()
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load(Properties.Resources.ConfigurationTemplate_EPTReport);
            XmlNode root = doc.DocumentElement;
            root.SelectSingleNode("Name").InnerText = textBoxName.Text;
            root.SelectSingleNode("InputSheetName").InnerText = textBoxInputSheetName.Text;
            root.SelectSingleNode("OutputSheetName").InnerText = textBoxOutputSheetName.Text;
            root.SelectSingleNode("ResultFormat/Text").InnerText = textBoxText.Text;
            root.SelectSingleNode("ResultFormat/Delimiter").InnerText = textBoxDelimiter.Text;
            root.SelectSingleNode("ResultFormat/TextColumn").InnerText = Convert.ToString(numericUpDownTextColumn.Value);
            root.SelectSingleNode("ResultFormat/ValueColumn").InnerText = Convert.ToString(numericUpDownValueColumn.Value);
            return doc;
        }

        public void Reload(XmlDocument doc)
        {
            XmlNode root = doc.DocumentElement;
            textBoxName.Text = root.SelectSingleNode("Name").InnerText;
            textBoxInputSheetName.Text = root.SelectSingleNode("InputSheetName").InnerText;
            textBoxOutputSheetName.Text = root.SelectSingleNode("OutputSheetName").InnerText;
            textBoxText.Text = root.SelectSingleNode("ResultFormat/Text").InnerText;
            textBoxDelimiter.Text = root.SelectSingleNode("ResultFormat/Delimiter").InnerText;
            numericUpDownTextColumn.Value = Convert.ToDecimal(root.SelectSingleNode("ResultFormat/TextColumn").InnerText);
            numericUpDownValueColumn.Value = Convert.ToDecimal(root.SelectSingleNode("ResultFormat/ValueColumn").InnerText);
        }
    }
}
