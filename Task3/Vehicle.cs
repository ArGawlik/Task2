using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.VehicleElements;

namespace Task3
{
    internal class Vehicle
    {
        public string type; 
        public Chassis chassis;
        public Engine engine;
        public Transmission transmission;

        public Vehicle(string type, Chassis chassis, Engine engine, Transmission transmission)
        {
            this.type = type;
            this.chassis = chassis;
            this.engine = engine;
            this.transmission = transmission;
        }

        public override string ToString()
        {
            return $"{type} details: \n" + engine + "\n" + chassis + "\n" + transmission;
        }
    }
}
