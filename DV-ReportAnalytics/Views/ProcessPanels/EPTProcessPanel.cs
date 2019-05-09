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
        private XmlDocument _doc;

        public EPTProcessPanel()
        {
            InitializeComponent();
        }

        public XmlDocument Submit()
        {
            _doc.SetNodeValue("Type", textBoxType.Text);
            _doc.SetNodeValue("Name", textBoxName.Text);
            _doc.SetNodeValue("InputSheetName", textBoxInputSheetName.Text);
            _doc.SetNodeValue("OutputSheetName", textBoxOutputSheetName.Text);
            _doc.SetNodeValue("ResultFormat/Text", textBoxText.Text);
            _doc.SetNodeValue("ResultFormat/Delimiter", textBoxDelimiter.Text);
            _doc.SetNodeValue("ResultFormat/TextColumn", numericUpDownTextColumn.Value);
            _doc.SetNodeValue("ResultFormat/ValueColumn", numericUpDownValueColumn.Value);
            return _doc;
        }

        public void Reload(XmlDocument doc)
        {
            textBoxType.Text = doc.GetNodeValue("Type");
            textBoxName.Text = doc.GetNodeValue("Name");
            textBoxInputSheetName.Text = doc.GetNodeValue("InputSheetName");
            textBoxOutputSheetName.Text = doc.GetNodeValue("OutputSheetName");
            textBoxText.Text = doc.GetNodeValue("ResultFormat/Text");
            textBoxDelimiter.Text = doc.GetNodeValue("ResultFormat/Delimiter");
            numericUpDownTextColumn.Value = doc.GetNodeValue<decimal>("ResultFormat/TextColumn");
            numericUpDownValueColumn.Value = doc.GetNodeValue<decimal>("ResultFormat/ValueColumn");
            _doc = doc;
        }
    }
}
