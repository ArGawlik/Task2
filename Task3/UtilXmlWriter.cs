using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Task5
{
    public class UtilXmlWriter
    {
        public static string WriteXml(params XElement[] element)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(sb, xws))
            {
                XDocument doc = new XDocument(element);
                doc.WriteTo(xw);
            }
            return sb.ToString();
        }

        public static XElement ConcatElements(string root, params XElement[] elements)
        {
            return new XElement(root, elements);
        }
    }
}
