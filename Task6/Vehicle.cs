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
        public string type { get; set; }
        public Chassis chassis { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
        public string additionalInfo { get; set; }
        public TransmissionTypes transmissionType { get; set; }
        public int transmissionGearsNumber { get; set; }
        public EngineType engineType { get; set; }
        public int enginePower { get; set; }
        public double? engineVolume { get; set; }
        public string vehicleId { get; set; }

        public Vehicle() { }

        public Vehicle(int enginePower, double? engineVolume, EngineType engineType, int transmissionGearsNumber, TransmissionTypes transmissionType, string carId)
        {
            this.enginePower = enginePower;
            this.engineVolume = engineVolume;
            this.engineType = engineType;
            this.transmissionType = transmissionType;
            this.transmissionGearsNumber = transmissionGearsNumber;
            this.vehicleId = carId;
        }

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
