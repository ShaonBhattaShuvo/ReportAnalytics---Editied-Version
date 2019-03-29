using System;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Views
{
    internal partial class EptConfigForm : Form, IEptConfigForm
    {
        public event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;

        public EptConfigForm(XmlDocument config)
        {
            InitializeComponent();
            //_InitializeDisplay(config);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void InitializeDisplay(XmlDocument config)
        {
            numericUpDownSpeedInterp.Value = config.GetNodeValue<decimal>("SpeedInterp");
            numericUpDownTorqueInterp.Value = config.GetNodeValue<decimal>("TorqueInterp");
            // update list
            XmlNodeList list = config.DocumentElement.SelectNodes("tablelist");
            foreach (XmlNode table in list)
                checkedListBox.Items.Add(table.GetNodeValue("name"), table.GetNodeValue<bool>("checked"));
        }

        private void GenerateConfig()
        {
            //// update check status
            //foreach (object itemchecked in checkedListBox.CheckedItems)
            //    _config.Tables[itemchecked.ToString()] = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(itemchecked));

            //// raise event
            //if (WorkbookConfigUpdate != null)
            //    WorkbookConfigUpdate.Invoke(this, new WorkbookConfigUpdateEventArgs(new TEptConfig(
            //        _config.Tables,
            //        (int)numericUpDownSpeedInterp.Value,
            //        (int)numericUpDownTorqueInterp.Value)));
        }
    }
}
