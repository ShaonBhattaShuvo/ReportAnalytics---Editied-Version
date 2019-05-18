using System;
using System.Windows.Forms;
using System.Xml;

namespace DV_ReportAnalytics
{
    internal class OpenFileWizardController
    {
        #region Properties and Fields
        private OpenFileWizard _wizardForm;
        private int _index;
        private XmlDocument _doc;
        #endregion

        #region Methods
        public OpenFileWizardController(OpenFileWizard wizard)
        {
            _wizardForm = wizard;
            InitializeClass();
        }

        private void InitializeClass()
        {
            _wizardForm.ButtonBack.Click += (object sender, EventArgs e) => Wizard_BackButtonClicked();
            _wizardForm.ButtonNext.Click += (object sender, EventArgs e) => Wizard_NextButtonClicked();
            _wizardForm.ButtonFinish.Click += (object sender, EventArgs e) => Wizard_FinishButtonClicked();
            // bind
            foreach (var page in _wizardForm.Pages)
                page.ContentUpdated += UpdateFromPage;
            // initialize document
            _doc = new XmlDocument();
            _doc.LoadXml(Properties.Resources.Root);
            _index = 0;
            LoadPage(0);
        }

        private void Wizard_NextButtonClicked()
        {
            LoadPage(1);
        }

        private void Wizard_BackButtonClicked()
        {
            LoadPage(-1);
        }

        private void Wizard_FinishButtonClicked()
        {
            // execute default parameters
            for (int i = _index; i < _wizardForm.Pages.Length - 1; i++)
                LoadPage(1);

            _wizardForm.UpdateContent(_doc);
            _wizardForm.Close();
        }

        private void ButtonEnable()
        {
            bool page1Ready =
                !string.IsNullOrWhiteSpace(_doc.GetNodeValue("Paths/Result")) &&
                !string.IsNullOrWhiteSpace(_doc.GetNodeValue("Paths/Config"));

            _wizardForm.ButtonBack.Enabled = _index > 0;
            _wizardForm.ButtonNext.Enabled = (_index < _wizardForm.Pages.Length - 1) && page1Ready;
            _wizardForm.ButtonFinish.Enabled = page1Ready;
        }

        private void UpdateFromPage(object sender, ContentUpdateEventArgs e)
        {
            // refresh nodes
            XmlNode newNode = _doc.ImportNode(e.Content.DocumentElement.SelectSingleNode(e.Message), true);
            try
            {
                XmlNode oldNode = _doc.DocumentElement.SelectSingleNode(e.Message);
                _doc.DocumentElement.ReplaceChild(newNode, oldNode);
            }
            catch
            {
                _doc.DocumentElement.AppendChild(newNode);
            }
            ButtonEnable();
        }

        private void LoadPage(int nextMove)
        {
            _index += nextMove;
            _wizardForm.PanelContent.Controls.Clear();
            _wizardForm.PanelContent.Controls.Add((UserControl)_wizardForm.Pages[_index]);
            _wizardForm.Pages[_index].Content = _doc;
            _wizardForm.Pages[_index].Show();
            ButtonEnable();
        }
        #endregion
    }
}
