using System;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.GUI
{
    public partial class EPTDisplaysView : UserControl, IEPTDisplaysView
    {
        public EPTDisplaysView()
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
            textBoxRowInterpolation.DataBindings.Add("Text", source, "RowInterpolation");
            textBoxColumnInterpolation.DataBindings.Add("Text", source, "ColumnInterpolation");
            textBoxMaximumItemsPerRow.DataBindings.Add("Text", source, "MaximumItemsPerRow");
        } 
        #endregion

    }
}
