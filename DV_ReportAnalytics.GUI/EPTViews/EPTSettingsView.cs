using System;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.App.Interfaces;
using DV_ReportAnalytics.App;

namespace DV_ReportAnalytics.GUI
{
    public partial class EPTSettingsView : UserControl, IEPTSettingsView
    {
        public EPTSettingsView()
        {
            InitializeComponent();
        }

        #region IView members
        public event EventHandler RequestClosed;

        public void Close()
        {
            RequestClosed?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

        public void BindData(object source, object arguments)
        {
            textBoxName.DataBindings.Add("Text", source, "ReportName");
            textBoxInputSheetName.DataBindings.Add("Text", source, "InputSheetName");
            textBoxOutputSheetName.DataBindings.Add("Text", source, "OutputSheetName");
            textBoxParameter.DataBindings.Add("Text", source, "Parameter");
            textBoxDelimiter.DataBindings.Add("Text", source, "Delimiter");
            textBoxParameterColumn.DataBindings.Add("Text", source, "ParameterColumn");
            textBoxValueColumn.DataBindings.Add("Text", source, "ValueColumn");
        } 
        #endregion

    }
}
