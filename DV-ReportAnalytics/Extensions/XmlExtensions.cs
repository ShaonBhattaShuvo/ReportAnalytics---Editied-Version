﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DV_ReportAnalytics.Extensions
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
    }
}
