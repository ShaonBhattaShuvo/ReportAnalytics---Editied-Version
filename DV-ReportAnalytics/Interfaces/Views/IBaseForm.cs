using System;
using System.Windows.Forms;

namespace DV_ReportAnalytics.Views
{
    /* Base form limits form's basic behaviors*/
    internal interface IBaseForm
    {
        // form control function: show window
        void Show();

        DialogResult ShowDialog();
    }
}
