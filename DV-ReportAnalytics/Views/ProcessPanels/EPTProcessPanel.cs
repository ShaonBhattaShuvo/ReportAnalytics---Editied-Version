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
        public event Action<object, FormUpdateEventArgs> ContentsUpdated;

        public XmlDocument Contents
        {
            set
            {
                textBoxType.Text = value.GetNodeValue("Type");
                textBoxName.Text = value.GetNodeValue("Name");
                textBoxInputSheetName.Text = value.GetNodeValue("InputSheetName");
                textBoxOutputSheetName.Text = value.GetNodeValue("OutputSheetName");
                textBoxText.Text = value.GetNodeValue("ResultFormat/Text");
                textBoxDelimiter.Text = value.GetNodeValue("ResultFormat/Delimiter");
                numericUpDownTextColumn.Value = value.GetNodeValue<decimal>("ResultFormat/TextColumn");
                numericUpDownValueColumn.Value = value.GetNodeValue<decimal>("ResultFormat/ValueColumn");
                ContentsUpdated?.Invoke(this, new FormUpdateEventArgs("true"));
            }
            get
            {
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.Load(Properties.Resources.ConfigurationTemplate_EPTReport);
                doc.SetNodeValue("Type", textBoxType.Text);
                doc.SetNodeValue("Name", textBoxName.Text);
                doc.SetNodeValue("InputSheetName", textBoxInputSheetName.Text);
                doc.SetNodeValue("OutputSheetName", textBoxOutputSheetName.Text);
                doc.SetNodeValue("ResultFormat/Text", textBoxText.Text);
                doc.SetNodeValue("ResultFormat/Delimiter", textBoxDelimiter.Text);
                doc.SetNodeValue("ResultFormat/TextColumn", numericUpDownTextColumn.Value);
                doc.SetNodeValue("ResultFormat/ValueColumn", numericUpDownValueColumn.Value);
                return doc;
            }
        }

        public EPTProcessPanel()
        {
            InitializeComponent();
        }
    }
}
