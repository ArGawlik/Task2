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

        public static void SaveToXmlFile(string fileName, string root, params XElement[] elements)
        {
            string basePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(basePath + @"\..\..\..");
            new XElement(root, elements).Save(basePath + @"\..\..\..\" + fileName);
            Console.WriteLine("File saved");
        }
    }
}
