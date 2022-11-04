using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace Task3.VehicleElements
{
    internal class Transmission
    {
        public TransmissionTypes type;
        int gearsNumber;
        string manufacturer;

        public Transmission(TransmissionTypes type, int gearsNumber, string manufacturer)
        {
            this.type = type;
            this.gearsNumber = gearsNumber;
            this.manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return "\nTransmission details:" +
                "\nType: " + type +
                "\nGears number: " + gearsNumber +
                "\nManufacturer: " + manufacturer;
        }

        public XElement getXmlElement()
        {
            return new XElement("Transmission",
                        new XElement("Type", type),
                        new XElement("GearsNumber", gearsNumber),
                        new XElement("Manufacturer", manufacturer));
        }
    }
}
