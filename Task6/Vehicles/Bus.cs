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

        public Bus(int seatsNumber, int enginePower, double engineVolume, EngineType engineType, int transmissionGearsNumber, TransmissionTypes transmissionType, string carId) : base(enginePower, engineVolume, engineType, transmissionGearsNumber, transmissionType, carId)
        {
            if (seatsNumber < 10)
            {
                throw new InitializationException("Seats number must be greater than 10");
            } 
            else if(seatsNumber > 120)
            {
                throw new InitializationException("Seats number must be less than 120");
            }
            type = "Bus";
            engine = new Engine(enginePower, engineVolume, engineType, "KRV99999");
            chassis = new Chassis(6, "POIU57679", 5000);
            transmission = new Transmission(transmissionType, transmissionGearsNumber, "Mercedes");
            this.seatsNumber = seatsNumber;
            additionalInfo = "Seats number: " + seatsNumber;
        }
    }
}
