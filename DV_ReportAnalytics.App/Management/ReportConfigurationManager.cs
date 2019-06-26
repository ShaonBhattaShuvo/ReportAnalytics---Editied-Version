using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;

namespace DV_ReportAnalytics.Management
{
    internal enum ConfigTypes : int
    {
        All = 0,
        EPTReportSettings,
        EPTReportDisplays
    }
    /// <summary>
    /// Manager for app configuration
    /// </summary>
    internal static class ReportConfigurationManager
    {
        /// <summary>
        /// Types and entries name must be registered here
        /// </summary>
        private static Dictionary<ConfigTypes, Func<ConfigurationSection>> Registry = 
            new Dictionary<ConfigTypes, Func<ConfigurationSection>>
        {
            { ConfigTypes.EPTReportSettings, () => new EPTReportSettings() },
            { ConfigTypes.EPTReportDisplays, () => new EPTReportDisplays() }

        };
        public static Configuration Config { get; private set; }
        static ReportConfigurationManager()
        {
            Reload();
        }

        private static void Register(ConfigTypes type)
        {
            string entry = type.ToString();
            if (Config.GetSection(entry) == null)
                Config.Sections.Add(entry, Registry[type]());
        }

        /// <summary>
        /// Register type and associated configuration
        /// </summary>
        public static void Reload()
        {
            Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Register(ConfigTypes.EPTReportSettings);
            Register(ConfigTypes.EPTReportDisplays);
            Save();
        }

        public static void Reset()
        {
            Config.Sections.Clear();
            Reload();
        }

        public static void Save()
        {
            Config.Save(ConfigurationSaveMode.Full);
        }

      

        #region Section manipulation
        public static object GetSectionGridItems(ConfigTypes type)
        {
            return ((BaseReportConfiguration)Config.GetSection(type.ToString())).AccessibleProperties;
        }

        public static ConfigurationSection GetSection(ConfigTypes type)
        {
            return Config.GetSection(type.ToString());
        }

        public static void ImportSection(ConfigTypes type, string xmlFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            ConfigurationSection settings = GetSection(type);
            settings.SectionInformation.SetRawXml(doc.OuterXml);
            Save();
        }

        public static void ExportSection(ConfigTypes type, string xmlFile)
        {
            XmlDocument doc = new XmlDocument();
            ConfigurationSection settings = GetSection(type);
            string xml = settings.SectionInformation.GetRawXml();
            Console.WriteLine("Printing xml:");
            Console.WriteLine(xml);
            doc.LoadXml(settings.SectionInformation.GetRawXml());
            doc.Save(xmlFile);
        }

        public static void ResetSection(ConfigTypes type)
        {
            ConfigurationSection settings = GetSection(type);
            ConfigurationSection newConfig = (ConfigurationSection)Activator.CreateInstance(settings.GetType());
            string newXml = newConfig.SectionInformation.GetRawXml();
            settings.SectionInformation.SetRawXml(newXml);
            Save();
        } 
        #endregion



    }
}
