﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DV_ReportAnalytics.Views;
using DV_ReportAnalytics.Events;
using DV_ReportAnalytics.Extensions;

namespace DV_ReportAnalytics.Controllers
{
    internal class OpenFileWizardController : IBaseController
    {
        #region Properties and Fields
        private OpenFileWizard _wizardForm;
        private int _index;
        private XmlDocument _doc;
        public event Action<object, ContentUpdateEventArgs> ContentUpdated;
        #endregion

        #region Methods
        public OpenFileWizardController(OpenFileWizard wizard)
        {
            _wizardForm = wizard;
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
            _doc.Load(Properties.Resources.Path);
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
            ContentUpdated?.Invoke(this, new ContentUpdateEventArgs(_doc, "From Wizard"));
        }

        private void ButtonEnable()
        {
            bool page1Ready =
                string.IsNullOrWhiteSpace(_doc.GetNodeValue("Paths/PathResult")) &&
                string.IsNullOrWhiteSpace(_doc.GetNodeValue("Paths/PathConfig"));

            _wizardForm.ButtonBack.Enabled = _index > 0;
            _wizardForm.ButtonNext.Enabled = (_index < _wizardForm.Pages.Length - 1) && page1Ready;
            _wizardForm.ButtonFinish.Enabled = page1Ready;
        }

        private void UpdateFromPage(object sender, ContentUpdateEventArgs e)
        {
            // refresh nodes
            XmlNode newPath = _doc.ImportNode(e.Content.DocumentElement.SelectSingleNode(e.Message), true);
            try
            {
                XmlNode oldPath = _doc.DocumentElement.SelectSingleNode(e.Message);
                _doc.ReplaceChild(newPath, oldPath);
            }
            catch
            {
                _doc.DocumentElement.AppendChild(newPath);
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
