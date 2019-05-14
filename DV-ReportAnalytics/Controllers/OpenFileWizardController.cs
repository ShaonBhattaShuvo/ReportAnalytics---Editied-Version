using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Views;

namespace DV_ReportAnalytics.Controllers
{
    internal class OpenFileWizardController
    {
        #region Properties and Fields
        private OpenFileWizard _wizardForm;
        private int _index;
        private XmlDocument _docs;
        #endregion

        #region Bindings
        private void InitializeClass()
        {
            _wizardForm.ButtonBack.Click += (object sender, EventArgs e) => Wizard_BackButtonClicked();
            _wizardForm.ButtonNext.Click += (object sender, EventArgs e) => Wizard_NextButtonClicked();
            _wizardForm.ButtonFinish.Click += (object sender, EventArgs e) => Wizard_FinishButtonClicked();

        }
        #endregion

        #region Methods
        public OpenFileWizardController(OpenFileWizard wizard)
        {
            _wizardForm = wizard;
        }

        private void Wizard_NextButtonClicked()
        {

        }

        private void Wizard_BackButtonClicked()
        {

        }

        private void Wizard_FinishButtonClicked()
        {

        }

        private void ButtonEnable()
        {

        }
        #endregion


    }
}
