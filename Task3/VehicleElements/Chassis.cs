using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Task3.VehicleElements
{
    internal class Chassis
    {
        int wheelsNumber;
        string idNumber;
        int permissibleLoad;

        public Chassis(int wheelsNumber, string idNumber, int permissibleLoad)
        {
            this.wheelsNumber = wheelsNumber;
            this.idNumber = idNumber;
            this.permissibleLoad = permissibleLoad;
        }

        public override string ToString()
        {
            return "\nChasis details:" +
                "\nWheels number: " + wheelsNumber +
                "\nID Number: " + idNumber +
                "\nPermissible load: " + permissibleLoad + "kg";
        }

        public XElement getXmlElement()
        {
            return new XElement("Chassis",
                        new XElement("WheelsNumber", wheelsNumber),
                        new XElement("IDNumber", idNumber),
                        new XElement("PermissibleLoad", permissibleLoad));
        }
    }
}
