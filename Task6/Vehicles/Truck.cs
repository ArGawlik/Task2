using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.VehicleElements;

namespace Task3.Vehicles
{
    internal class Truck : Vehicle
    {
        public double height;
        public Truck(double height)
        {
            type = "Truck";
            engine = new Engine(500, 6.0, EngineType.Diesel, "ASD123");
            chassis = new Chassis(8, "FGH8824", 10000);
            transmission = new Transmission(TransmissionTypes.Manual, 6, "Volvo");
            this.height = height;
            additionalInfo = "Vehicle height: " + height + "m";
        }

        public Truck(double height, int enginePower, EngineType engineType, double engineVolume, int transmissionGearsNumber, TransmissionTypes transmissionType, string carId) : base(enginePower, engineVolume, engineType, transmissionGearsNumber, transmissionType, carId)
        {
            type = "Truck";

            engine = new Engine(enginePower, engineVolume, engineType, "ASD123");
            chassis = new Chassis(8, "FGH8824", 10000);
            transmission = new Transmission(transmissionType, transmissionGearsNumber, "Volvo");
            this.height = height;
            additionalInfo = "Vehicle height: " + height + "m";
        }
    }
}
