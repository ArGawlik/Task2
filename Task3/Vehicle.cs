using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Task3.VehicleElements;

namespace Task3
{
    internal abstract class Vehicle
    {
        public string type;
        public Chassis chassis;
        public Engine engine;
        public Transmission transmission;

        public override string ToString()
        {
            return $"{type} details: \n" + engine + "\n" + chassis + "\n" + transmission +"\n";
        }

        public string getXmlInformation()
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(sb, xws))
            {
                XDocument doc = new XDocument(
                    new XElement(type,
                        engine.getXmlElements(),
                        transmission.getXmlElements(),
                        chassis.getXmlElements())
                );
                doc.WriteTo(xw);
            }
            return sb.ToString();
        }
    }
}
