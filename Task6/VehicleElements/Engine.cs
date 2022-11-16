using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Task6.Exceptions;

namespace Task3.VehicleElements
{
    public class Engine
    {
        public int power;
        public double? volume;
        public EngineType type;
        public string serialNumber;

        public Engine(int power, double? volume, EngineType type, string serialNumber)
        {
            if (type == EngineType.Electric && volume != null)
            {
                throw new InitializationException("Electric engines don't have volume");
            }
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.serialNumber = serialNumber;
        }

        public override string ToString()
        {
            return "\nEngine details:" +
                "\nPower: " + power + "HP" +
                (volume == null?"":"\nVolume: " + volume + "cdm") +
                "\nType: " + type +
                "\nSerial number: " + serialNumber;
        }

        public XElement getXmlElement()
        {
            return new XElement("Engine",
                        new XElement("Power", power),
                        new XElement("Volume", volume),
                        new XElement("Type", type),
                        new XElement("SerialNumber", serialNumber));
        }
    }
}
