using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.VehicleElements;

namespace Task3.Vehicles
{
    internal class PassengerCar : Vehicle
    {
        public int maxSpeed;
        public PassengerCar(int maxSpeed)
        {
            type = "PassengerCar";
            engine = new Engine(120, 1.8, EngineType.Gasoline, "TUY5775");
            chassis = new Chassis(4, "FFLJ7824", 1500);
            transmission = new Transmission(TransmissionTypes.Manual, 6, "Skoda");
            this.maxSpeed = maxSpeed;
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nAdditional info:"+
                "\nMax speed: " + maxSpeed + "km/h";
        }
    }
}
