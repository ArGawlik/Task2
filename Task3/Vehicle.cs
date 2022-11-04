using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Task3.VehicleElements;
using Task5;

namespace Task3
{
    internal abstract class Vehicle
    {
        public string type;
        public Chassis chassis;
        public Engine engine;
        public Transmission transmission;
        public string additionalInfo;

        public override string ToString()
        {
            return $"{type} details:\n" +
                $"{engine}\n" +
                $"{chassis}\n" +
                $"{transmission}\n" + 
                $"Additional info: \n{additionalInfo}";
        }
        public XElement getXmlElement()
        {
            return new XElement(type,
                        engine.getXmlElement(),
                        transmission.getXmlElement(),
                        chassis.getXmlElement(),
                        new XElement("AdditionalInfo", additionalInfo));
        }
    }
}
