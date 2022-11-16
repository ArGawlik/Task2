using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Task3.VehicleElements;
using Task6.Exceptions;

namespace Task3.Vehicles
{
    internal class Bus : Vehicle
    {
        int seatsNumber;

        // some default bus
        public Bus(int seatsNumber) : base()
        {
            if (seatsNumber < 10)
            {
                throw new InitializationException("Seats number must be greater than 10");
            }
            else if (seatsNumber > 120)
            {
                throw new InitializationException("Seats number must be less than 120");
            }
            type = "Bus";
            engine = new Engine(250, 4.5, EngineType.Diesel, "KRV99999");
            chassis = new Chassis(6, "POIU57679", 5000);
            transmission = new Transmission(TransmissionTypes.Auto, 8, "Mercedes");
            this.seatsNumber = seatsNumber;
            additionalInfo = "Seats number: " + seatsNumber;
        }

        public Bus(int seatsNumber, string vehicleId, Engine engine, Transmission transmission, Chassis chassis)
        {
            if (seatsNumber < 10)
            {
                throw new InitializationException("Seats number must be greater than 10");
            }
            else if (seatsNumber > 120)
            {
                throw new InitializationException("Seats number must be less than 120");
            }
            type = "Bus";
            this.vehicleId = vehicleId;
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
            additionalInfo = "Seats number: " + seatsNumber;
            initDict();
        }
    }
}
