using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml.Linq;

namespace DV_ReportAnalytics.App
{
    public class ConfigurationManager
    {
        private Dictionary<ReportTypes, ApplicationSettingsBase> _configs;

        // register new config here
        public ConfigurationManager()
        {
            _configs = new Dictionary<ReportTypes, ApplicationSettingsBase>()
            {
                {ReportTypes.EPTReport, EPTConfig.Default }
            };
        }

        public ApplicationSettingsBase this[ReportTypes type]
        {
            get
            {
                return _configs[type];
            }
        }

        public void ResetAll()
        {
            foreach (var i in _configs)
                i.Value.Reset();
        }

        public void ReloadAll()
        {
            foreach (var i in _configs)
                i.Value.Reload();
        }

        public void SaveAll()
        {
            foreach (var i in _configs)
                i.Value.Save();
        }

        public void Reset(ReportTypes type)
        {
            _configs[type].Reset();
        }

        public void Reload(ReportTypes type)
        {
            _configs[type].Reload();
        }

        public void Save(ReportTypes type)
        {
            _configs[type].Save();
        }

        public void Import(ReportTypes type, string path)
        {
            XDocument xml = XDocument.Load(path);
            var config = _configs[type];
            var props = config.GetType().GetProperties();
            foreach (var p in props)
            {
                var pt = p.PropertyType;
                p.SetValue(config, Convert.ChangeType(xml.Root.Element(p.Name).Value, pt));
            }
        }

        public void Export(ReportTypes type, string path)
        {
            XDocument xml = new XDocument(new XElement("DV_ReportAnalytics"));
            var config = _configs[type];
            var props = config.GetType().GetProperties();
            foreach (var p in props)
            {
                xml.Root.Add(new XElement(p.Name, p.GetValue(config)));
            }
            xml.Save(path);
        }

        public static void Import(ApplicationSettingsBase config, string path)
        {
            XDocument xml = XDocument.Load(path);
            var props = config.GetType().GetProperties();
            foreach (var p in props)
            {
                var pt = p.PropertyType;
                p.SetValue(config, Convert.ChangeType(xml.Root.Element(p.Name).Value, pt));
            }
        }

        public static void Export(ApplicationSettingsBase config, string path)
        {
            XDocument xml = new XDocument(new XElement("DV_ReportAnalytics"));
            var props = config.GetType().GetProperties();
            foreach (var p in props)
            {
                xml.Root.Add(new XElement(p.Name, p.GetValue(config)));
            }
            xml.Save(path);
        }
    }
}
