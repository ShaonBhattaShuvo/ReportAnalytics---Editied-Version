using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Types;

namespace DV_ReportAnalytics.Views
{
    internal partial class EptConfigForm : Form, IWorkbookModelView
    {
        public event WorkbookConfigUpdateEventHandler WorkbookConfigUpdate;
        private TEptConfig _config;

        public EptConfigForm(TEptConfig config)
        {
            InitializeComponent();
            numericUpDownSpeedInterp.Value = (decimal)config.SpeedInterp;
            numericUpDownTorqueInterp.Value = (decimal)config.TorqueInterp;
            _config = config;
            // update list
            foreach (KeyValuePair<string, bool> kvp in _config.Tables)
                checkedListBox.Items.Add(kvp.Key, kvp.Value);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (object itemchecked in checkedListBox.CheckedItems)
                _config.Tables[itemchecked.ToString()] = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(itemchecked));

            // raise event
            if (WorkbookConfigUpdate != null)
                WorkbookConfigUpdate.Invoke(this, new WorkbookConfigUpdateEventArgs(new TEptConfig(
                    _config.Tables, 
                    (int)numericUpDownSpeedInterp.Value,
                    (int)numericUpDownTorqueInterp.Value)));
        }
    }
}
