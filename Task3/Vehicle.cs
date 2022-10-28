using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.VehicleElements;

namespace Task3
{
    internal abstract class Vehicle
    {
        public string type;
        public Chassis chassis;
        public Engine engine;
        public Transmission transmission;

        public override string ToString()
        {
            return $"{type} details: \n" + engine + "\n" + chassis + "\n" + transmission +"\n";
        }
    }
}
