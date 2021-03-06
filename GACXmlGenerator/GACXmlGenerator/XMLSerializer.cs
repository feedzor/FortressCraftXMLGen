﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GACXmlGenerator
{
    public static class XMLSerializer
    {
        public static string Serialize<T>(this T value,bool keepXmlHeader = true)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return BeautifyXML(stringWriter.ToString(), keepXmlHeader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public static T Deserialize<T>(String xml)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(xml);
            MemoryStream stream = new MemoryStream(byteArray);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T obj = (T)serializer.Deserialize(stream);
            return obj;
        }

        /// <summary>
        /// Beautify XML, to make it human readable and not a simple one liner
        /// http://stackoverflow.com/questions/1123718/format-xml-string-to-print-friendly-xml-string
        /// </summary>
        /// <param name="XML"></param>
        /// <returns></returns>
        public static String BeautifyXML(String xml, bool keepXmlHeader)
        {
            var stringBuilder = new StringBuilder();

            var element = XElement.Parse(xml);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = !keepXmlHeader;
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            settings.NamespaceHandling = NamespaceHandling.OmitDuplicates;

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                element.Save(xmlWriter);
            }

            return stringBuilder.ToString();
        }
    }


}
