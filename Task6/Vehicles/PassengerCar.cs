using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.VehicleElements;
using Task6.Exceptions;

namespace Task3.Vehicles
{
    internal class PassengerCar : Vehicle
    {
        public int maxSpeed;

        // some default car
        public PassengerCar(int maxSpeed) : base()
        {
            if(maxSpeed < 90)
            {
                throw new InitializationException("Max speed cannot be less than 90");
            }
            else if(maxSpeed > 350)
            {
                throw new InitializationException("Max speed cannot be more than 350");
            }
            type = "PassengerCar";
            engine = new Engine(120, 1.8, EngineType.Gasoline, "TUY5775");
            chassis = new Chassis(4, "FFLJ7824", 1500);
            transmission = new Transmission(TransmissionTypes.Manual, 6, "Skoda");
            this.maxSpeed = maxSpeed;
            additionalInfo = "Max speed: " + maxSpeed + "km/h";
        }

        public PassengerCar(int maxSpeed, string vehicleId, Engine engine, Transmission transmission, Chassis chassis)
        {
            if (maxSpeed < 90)
            {
                throw new InitializationException("Max speed cannot be less than 90");
            }
            else if (maxSpeed > 350)
            {
                throw new InitializationException("Max speed cannot be more than 350");
            }
            type = "PassengerCar";
            this.maxSpeed = maxSpeed;
            this.vehicleId = vehicleId;
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
            initDict();
        }
    }
}
