using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DV_ReportAnalytics.Extensions
{
    internal static class XmlExtension
    {
        // generic method for xml document
        // cast string to to other type
        public static T GetValue<T>(this XmlDocument source, string xpath)
        {
            string text = source.DocumentElement.SelectSingleNode(xpath).InnerText;
            return (T)Convert.ChangeType(text, typeof(T));
        }

        // get inner text of specified xpath
        public static string GetValue(this XmlDocument source, string xpath)
        {
            return source.DocumentElement.SelectSingleNode(xpath).InnerText;
        }
    }
}
