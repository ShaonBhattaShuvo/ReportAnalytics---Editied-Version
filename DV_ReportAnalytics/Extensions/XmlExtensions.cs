using System;
using System.Xml;

namespace DV_ReportAnalytics
{
    internal static class XmlExtensions
    {
        // generic method for xml document
        // cast string to to other type
        public static T GetNodeValue<T>(this XmlDocument source, string xpath)
        {
            string text = source.DocumentElement.SelectSingleNode(xpath).InnerText;
            return (T)Convert.ChangeType(text, typeof(T));
        }

        // get inner text of specified xpath
        public static string GetNodeValue(this XmlDocument source, string xpath)
        {
            return source.DocumentElement.SelectSingleNode(xpath).InnerText;
        }

        public static void SetNodeValue<T>(this XmlDocument source, string xpath, T value)
        {
            source.DocumentElement.SelectSingleNode(xpath).InnerText = Convert.ToString(value);
        }

        public static void SetNodeValue(this XmlDocument source, string xpath, string value)
        {
            source.DocumentElement.SelectSingleNode(xpath).InnerText = value;
        }

        // generic method for xml node
        // cast string to to other type
        public static T GetNodeValue<T>(this XmlNode source, string xpath)
        {
            string text = source.SelectSingleNode(xpath).InnerText;
            return (T)Convert.ChangeType(text, typeof(T));
        }

        // get inner text of specified xpath
        public static string GetNodeValue(this XmlNode source, string xpath)
        {
            return source.SelectSingleNode(xpath).InnerText;
        }

        public static void SetNodeValue<T>(this XmlNode source, string xpath, T value)
        {
            source.SelectSingleNode(xpath).InnerText = Convert.ToString(value);
        }

        public static void SetNodeValue(this XmlNode source, string xpath, string value)
        {
            source.SelectSingleNode(xpath).InnerText = value;
        }

        public static void UpdateNode(this XmlDocument source, XmlDocument target, string xpath)
        {
            // refresh nodes
            XmlNode newNode = source.ImportNode(target.DocumentElement.SelectSingleNode(xpath), true);
            try
            {
                XmlNode oldNode = source.DocumentElement.SelectSingleNode(xpath);
                source.DocumentElement.ReplaceChild(newNode, oldNode);
            }
            catch
            {
                source.DocumentElement.AppendChild(newNode);
            }
        }
    }
}
