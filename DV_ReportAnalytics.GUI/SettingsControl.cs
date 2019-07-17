﻿using System;
using System.Windows.Forms;
using System.Xml;

namespace DV_ReportAnalytics.UI
{
    internal partial class SettingsControl : UserControl, IBaseControl
    {
        private IBaseControl _processPanel;
        private string _currentPath;
        public event Action<object, ContentUpdateEventArgs> ContentUpdated;

        public XmlDocument Content
        {
            set
            {
                string newPath = value.GetNodeValue("Paths/Config");
                if (newPath.Equals(_currentPath))
                    _processPanel.Content = value;
                else
                    NewControl(newPath);
                _currentPath = newPath;
            }
            get { return _processPanel.Content; }
        }


        public SettingsControl()
        {
            InitializeComponent();
        }

        private void UpdateContent()
        {
            ContentUpdated?.Invoke(this, new ContentUpdateEventArgs(Content, "Settings"));
        }

        private void NewControl(string configPath)
        {
            Controls.Clear(); // clear before show new view
            _processPanel?.Dispose();


            XmlDocument d = new XmlDocument();
            d.Load(configPath);
            ModelTypes t = d.GetNodeValue("Settings/Type").ToModelTypes();
            switch (t)
            {
                case ModelTypes.EPTReport:
                    _processPanel = new EPTProcessPanel();
                    break;
                default:
                    _processPanel = null;
                    break;
            }
            // add to panel
            if (_processPanel != null)
            {
                _processPanel.ContentUpdated += (object sender, ContentUpdateEventArgs e) => UpdateContent();
                _processPanel.Content = d;
                _processPanel.Dock = DockStyle.Fill;
                Controls.Add((UserControl)_processPanel);
                _processPanel.Show();
            }
        }
    }
}