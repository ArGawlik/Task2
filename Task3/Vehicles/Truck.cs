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
        public Truck()
        {
            type = "Truck";
            engine = new Engine(500, 6.0, EngineType.Diesel, "ASD123");
            chassis = new Chassis(8, "FGH8824", 10000);
            transmission = new Transmission(TransmissionTypes.Manual, 6, "Volvo");
        }
        
    }
}
