using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml.Linq;
using System.Reflection;
using DV_ReportAnalytics.App.Management;

namespace DV_ReportAnalytics.App
{
    public class ConfigurationManager
    {
        private Dictionary<ReportTypes, ApplicationSettingsBase> _configs;
        private static ConfigurationManager defaultInstance; // singlton instance
        public static event EventHandler<EventArgs<string>> ExceptionThrown; // handle exception for GUI presentation
        public static ConfigurationManager Default
        {
            get
            {
                if (defaultInstance == null)
                    defaultInstance = new ConfigurationManager();
                return defaultInstance;
            }
        }

        // register new config here
        private ConfigurationManager()
        {
            _configs = new Dictionary<ReportTypes, ApplicationSettingsBase>()
            {
                { ReportTypes.EPTReport, EPTConfig.Default }
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
                Reset(i.Value);
        }

        public void ReloadAll()
        {
            foreach (var i in _configs)
                Reload(i.Value);
        }

        public void SaveAll()
        {
            foreach (var i in _configs)
                Save(i.Value);
        }

        public void Reset(ReportTypes type)
        {
            Reset(_configs[type]);
        }

        public void Reload(ReportTypes type)
        {
            Reload(_configs[type]);
        }

        public void Save(ReportTypes type)
        {
            Save(_configs[type]);
        }

        public void Import(ReportTypes type, string path)
        {
            Import(_configs[type], path);
        }

        public void Export(ReportTypes type, string path)
        {
            Export(_configs[type], path);
        }

        public static void Reset(ApplicationSettingsBase config)
        {
            config.Reset();
        }

        public static void Reload(ApplicationSettingsBase config)
        {
            config.Reload();
        }

        public static void Save(ApplicationSettingsBase config)
        {
            config.Save();
        }

        public static void Import(ApplicationSettingsBase config, string path)
        {
            XDocument xml = XDocument.Load(path);
            try
            {
                // validate config before importing
                const string typeParam = "ReportType";
                string configType = (string)config.GetType().GetProperty(typeParam).GetValue(config);
                string xmlType = xml.Root.Element(typeParam).Value;
                if (!string.Equals(configType, xmlType))
                    throw new Exception();

                // starting importing
                var props = config.GetType().GetProperties(
                    BindingFlags.DeclaredOnly |
                    BindingFlags.Instance |
                    BindingFlags.Public);
                foreach (var p in props)
                {
                    if (p.Name == typeParam)
                        continue;
                    var pt = p.PropertyType;
                    p.SetValue(config, Convert.ChangeType(xml.Root.Element(p.Name).Value, pt));
                }
            }
            catch
            {
                string errormsg = "Invalid config!";
                Console.WriteLine(errormsg);
                ExceptionThrown?.Invoke(Default, new EventArgs<string>(errormsg));
            }
        }

        public static void Export(ApplicationSettingsBase config, string path)
        {
            XDocument xml = new XDocument(new XElement("DV_ReportAnalytics"));
            var props = config.GetType().GetProperties(
                BindingFlags.DeclaredOnly|
                BindingFlags.Instance|
                BindingFlags.Public);
            foreach (var p in props)
            {
                xml.Root.Add(new XElement(p.Name, p.GetValue(config)));
            }
            xml.Save(path);
        }
    }
}
